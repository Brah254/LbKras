using System;
using System.Threading;
using System.Windows;

namespace Logicar
{
    public class Class1
    {
        public event EventHandler<int> SharedNumberChanged;

        private int sharedNumber = 0;
        private readonly object lockObject = new object();
        private readonly Timer timer;

        public int SharedNumber
        {
            get { return sharedNumber; }
            private set
            {
                lock (lockObject)
                {
                    sharedNumber = value;
                }
                OnSharedNumberChanged(sharedNumber);
            }
        }

        public Class1()
        {
            timer = new Timer(TimerCallback, null, 0, 100); // Установите интервал таймера на ваш выбор (в миллисекундах)

            Thread thread1 = new Thread(IncrementNumber);
            Thread thread2 = new Thread(IncrementNumber);
            thread1.Start();
            thread2.Start();
        }

        private void TimerCallback(object state)
        {
            // Обновляем значение на форме из основного потока
            OnSharedNumberChanged(sharedNumber);
        }

        private void IncrementNumber()
        {
            for (int i = 0; i < 100; i++)
            {
                lock (lockObject)
                {
                    sharedNumber++;
                }
                Thread.Sleep(1); // Имитируем небольшую задержку для создания эффекта анимации
            }
        }

        protected virtual void OnSharedNumberChanged(int newValue)
        {
            SharedNumberChanged?.Invoke(this, newValue);
        }
    }
}
