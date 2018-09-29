using System;
using System.Collections.Generic;
using System.Text;

namespace Banco_KJC
{
    class Cuenta
    {
        private int NIP;
        private string num_cuenta;
        private string id_usr;

        public Cuenta(int _NIP, string _num_cuenta, string _id)
        {
            this.NIP = _NIP;
            this.num_cuenta = _num_cuenta;
            this.id_usr = _id;
        }
    }
}
