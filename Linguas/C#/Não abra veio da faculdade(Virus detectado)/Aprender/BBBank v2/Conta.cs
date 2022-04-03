using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBBank_v2
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public string Numero {  get; private set; }
        public Usuario Titular { get; private set; }
        private string Senha { get; set; }
        public string PIX { get; private set; }
        public List<String> Logs { get; private set; }

        public Conta(string numero, Usuario titular, string senha, string PIX)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Senha = senha;
            this.PIX = PIX;
            this.Logs = new List<String>();
            this.Saldo = 0;
        }

        public bool SenhaCorreta(string senha)
        {
            return this.Senha.Equals(senha);
        }

        public void Log(string log)
        {
            Logs.Add(log);
        }


        public bool Deposito (double valor)
        {
            if(valor > 0)
            {
                this.Saldo += valor;
                this.Log("Deposito realizado no valor de R$" + valor);
                return true;
            }
            this.Log("Deposito não realizado!");
            return false;
        }

        public bool Saque (double valor)
        {
            if(valor > 0 && valor <= this.Saldo)
            {
                this.Saldo -= valor;
                this.Log("Saque realizado no valor de R$" + valor);
                return true;
            }
            this.Log("Saque não realizado!");
            return false;
        }

        public void ReceberTransferencia(Conta remetente, double valor)
        {
            this.Saldo += valor;
            this.Log("Recebido de " + remetente.Titular.Nome + ", o valor de R$" + valor);
        }

        public bool Transferencia(Conta destinatario, double valor)
        {
            if(valor > 0 && valor <= this.Saldo)
            {
                this.Saldo -= valor;
                this.Log("Transferido para " + destinatario.Titular.Nome + ", o valor de R$" + valor);
                destinatario.ReceberTransferencia(this, valor);
                return true;
            }
            return false;
        }

    }
}
