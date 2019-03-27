using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Users
    {
        private int[] entryAttempts;

        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public int this[int i]
        {
            get
            {
                return entryAttempts[i];
            }
            set
            {
                entryAttempts[i] = value;
            }
        }
    }
}
