using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2._2
{
    class User
    {
        public string Name { get; set; }

        private List<Figure> _canvas=new List<Figure>();

        public User(string name)
        {
            Name = name;
        }
        public void AddFigure(Figure figure)
        {
            _canvas.Add(figure);
        }
        public void DeleteAll()
        {
            _canvas.Clear();
        }
        public void ShowFigures()
        {
            foreach (var item in _canvas)
            {
                Console.WriteLine(item.ToString()) ;
            }
        }
    }
}
