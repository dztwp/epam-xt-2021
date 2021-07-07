using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_8._1.UserAwards.Common.Entities;
using Task_8._1.UserAwards.DAL.Interfaces;
using Newtonsoft.Json;
using System.IO;

namespace Task_8._1.UserAwards.DAL.JsonDAL
{
    public class AwardJsonDAO : IAwardDAO
    {
        public const string JsonFilesPathForAwards = @"D:\epam-xt-2021\Task 8\Task 8.1\Files_Awards\";
        public const string JsonFilesPathForRelations = @"D:\epam-xt-2021\Task 8\Task 8.1\Files_Relations\";

        public void AddAward(Award award)
        {
            if (!IsAwardAlreadyExist(award.Title))
            {
                string json = JsonConvert.SerializeObject(award);
                File.WriteAllText(GetJsonFilePath(award.Id), json);
            }
            else
            {
                throw new ArgumentException(String.Format("Award {0} is already exist", award.Title));
            }
        }

        public IEnumerable<Award> GetAllAwards()
        {
            List<Award> listOfAwards = new List<Award>();
            string[] paths = Directory.GetFiles(JsonFilesPathForAwards);
            foreach (var item in paths)
            {
                string jsonString = File.ReadAllText(item);
                listOfAwards.Add(JsonConvert.DeserializeObject<Award>(jsonString));
            }
            return listOfAwards;
        }

        private static string GetJsonFilePath(Guid id)
        {
            return JsonFilesPathForAwards + id + ".json";
        }

        public static Award GetStaticAwardById(Guid awardId)
        {
            string[] paths = Directory.GetFiles(JsonFilesPathForAwards);
            string pathFile = paths.FirstOrDefault(x => x.Contains(awardId.ToString()));
            
            return JsonConvert.DeserializeObject<Award>(File.ReadAllText(pathFile));

        }
        public bool IsAwardAlreadyExist(string title)
        {
            IEnumerable<Award> listOfAwards = GetAllAwards();
            if(listOfAwards.FirstOrDefault(x=>x.Title==title)==null)
            {
                return false;
            }
            return true;
        }

        public Award GetAwardById(Guid id)
        {
            return GetStaticAwardById(id);
        }

        public void DeleteAward(Guid id)
        {
            if (File.Exists(GetJsonFilePath(id)))
            {
                DeleteAwardRelations(id);
                File.Delete(GetJsonFilePath(id));
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
        private void DeleteAwardRelations(Guid id)
        {
            string[] paths = Directory.GetFiles(JsonFilesPathForRelations);
            var pathFile = paths.Where(x => x.Contains(id.ToString()));

            foreach (var item in pathFile)
            {
                File.Delete(item);
            }
        }

        public void UpdateAward(Award award)
        {
            if(File.Exists(GetJsonFilePath(award.Id)))
            {
                string json = JsonConvert.SerializeObject(award);
                File.WriteAllText(GetJsonFilePath(award.Id), json);
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
    }
}
