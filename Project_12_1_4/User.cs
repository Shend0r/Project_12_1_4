using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_12_1_4
{
    internal class User
    {
        public string Login { get; set; }

        /// <summary>
        /// Имитация взаимодействия с API, получение данных по ключевому слову Login (Типо работа с бд через API)
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return "MyName";
        }


        /// <summary>
        /// Имитация взаимодействия с API, получение данных по ключевому слову Login (Типо работа с бд через API)
        /// </summary>
        /// <returns></returns>
        public bool IsPremium()
        {
            return false;
        }
    }
}
