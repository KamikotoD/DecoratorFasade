using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasade
{
    public class StartTheCar
    {
        private bool _showProcess;
        public StartTheCar(bool showProcess = false)
        {
            _showProcess = showProcess; 
        }
        public void ShowProcess(string str)
        {
            if (_showProcess)
                Console.WriteLine(str);
        }
        public void TurnOnTheIgnition()
        {
            //Включаем зажигание
            ShowProcess("Включаем зажигание");
        }
        public void ScanOfSystem()
        {
            //Начинаеться сканирование системы
            ShowProcess("Начинаеться сканирование системы");
        }
        public void TurnOnStarter()
        {
            //Включается стартер
            //Стартер прокручивает Маховик
            //Маховик находиться на Коленчатом Валу
            ShowProcess("Включается стартер\nСтартер прокручивает Маховик\nМаховик находиться на Коленчатом Валу");
        }
        public void CrankShaftInMotion()
        {
            //Коленчатый Вал приводит в движении Разпределительный Вал,
            //и одновременно генератор тока, и помпу из системы охлаждения
            ShowProcess("Коленчатый Вал приводит в движении Разпределительный Вал,\n"+
                "и одновременно генератор тока, и помпу из системы охлаждения");
        }
        public void CamShaftInMotion()
        {
            //Разпред Вал открывает клапана, через которые из топлевные системы
            //(бензонасос, ТНВД) подаются в  целиндры гарючая смесь, и через
            //трамплер подаеться искра на свечи в цилиндре от чего происходит 
            //воспламенение гарючей смеми, что приводит целиндры в движение
            ShowProcess("Разпред Вал открывает клапана, через которые из топлевные системы\n" +
                "(бензонасос, ТНВД) подаются в  целиндры гарючая смесь, и через\n" +
                "трамплер подаеться искра на свечи в цилиндре от чего происходит\n" +
                "воспламенение гарючей смеми, что приводит целиндры в движение");
        }
        public void CylindersInMotion()
        {
            //Машина начинает работать на холостом ходу
            ShowProcess("Машина начинает работать на холостом ходу");
        }

    }
}
