using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Task_8._1.UserAwards.Common.Entities;
using Task_8._1.UserAwards.DAL.Interfaces;

namespace Task_8._1.UserAwards.DAL.JsonDAL
{
    public class UserJsonDAO : IUserDAO
    {
        public const string JsonFilesPathForUsers = @"D:\epam-xt-2021\Task 8\Task 8.1\Files_Users\";
        public const string JsonFilesPathForRelations = @"D:\epam-xt-2021\Task 8\Task 8.1\Files_Relations\";

        public void AddUser(User user)
        {
            string json = JsonConvert.SerializeObject(user);

            File.WriteAllText(GetJsonFilePath(JsonFilesPathForUsers, user.Id), json);

        }
        public void DeleteUser(Guid id)
        {
            if (File.Exists(GetJsonFilePath(JsonFilesPathForUsers, id)))
            {
                DeleteUserRelations(id);
                File.Delete(GetJsonFilePath(JsonFilesPathForUsers, id));
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
        private void DeleteUserRelations(Guid id)
        {
            string[] paths = Directory.GetFiles(JsonFilesPathForRelations);
            var pathFile = paths.Where(x => x.Contains(id.ToString()));

            foreach (var item in pathFile)
            {
                File.Delete(item);
            }
        }
        public IEnumerable<User> GetAllUsers()
        {
            List<User> listOfUsers = new List<User>();
            string[] paths = Directory.GetFiles(JsonFilesPathForUsers);
            foreach (var item in paths)
            {
                string jsonString = File.ReadAllText(item);
                listOfUsers.Add(JsonConvert.DeserializeObject<User>(jsonString));
            }
            return listOfUsers;
        }

        private static string GetJsonFilePath(string path, Guid id)
        {
            return path + id + ".json";
        }
        private static string GetJsonFilePath(string path, Guid idUser, Guid idAward)
        {
            return path + idUser + "." + idAward + ".json";
        }

        public bool AssignAwardToUser(Guid userId, Guid awardId)
        {
            string pathToFile = GetJsonFilePath(JsonFilesPathForRelations, userId, awardId);
            if (!File.Exists(pathToFile))
            {
                string json = JsonConvert.SerializeObject(new RelationUserAward(userId, awardId));
                File.WriteAllText(pathToFile, json);
                return true;
            }
            else
            {
                return false;
            }  
        }

        public IEnumerable<Award> GetUserAwards(Guid userId)
        {
            List<Award> listOfAwards = new List<Award>();
            string[] paths = Directory.GetFiles(JsonFilesPathForRelations);
            foreach (var item in paths)
            {
                string jsonString = File.ReadAllText(item);
                RelationUserAward tmp = JsonConvert.DeserializeObject<RelationUserAward>(jsonString);
                if (tmp.UserId == userId)
                {
                    listOfAwards.Add(AwardJsonDAO.GetStaticAwardById(tmp.AwardId));
                }
            }
            return listOfAwards;
        }

        public bool IsUserExist(string name)
        {
            IEnumerable<User> listOfUsers = GetAllUsers();
            foreach (var item in listOfUsers)
            {
                if (item.Name == name)
                {
                    return true;
                }
            }
            return false;

        }

        public User GetUserById(Guid id)
        {
            string[] paths = Directory.GetFiles(JsonFilesPathForUsers);
            string pathFile = paths.FirstOrDefault(x => x.Contains(id.ToString()));

            return JsonConvert.DeserializeObject<User>(File.ReadAllText(pathFile));
        }

        public bool IsUserHasAward(Guid userId, Guid awardId)
        {
            string[] paths = Directory.GetFiles(JsonFilesPathForRelations);
            string pathFile = paths.FirstOrDefault(x => x.Contains(userId.ToString())&&x.Contains(awardId.ToString()));
            if (pathFile == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void UpdateUser(User user)
        {
            if (File.Exists(GetJsonFilePath(JsonFilesPathForUsers,user.Id)))
            {
                string json = JsonConvert.SerializeObject(user);
                File.WriteAllText(GetJsonFilePath(JsonFilesPathForUsers, user.Id), json);
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
    }
}
