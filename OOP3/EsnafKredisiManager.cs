using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class EsnafKredisiManager : IKrediManager
    {
        public void BiseYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi hesaplandı.");
        }
    }
}
