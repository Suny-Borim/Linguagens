using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoSuny2._0
{
    internal class Conta
    {
        private List<string> logs;
        public Usuario usuario { get; private set; }
        private string senha { get; set; }
        public string titular { get; private set; }
        public string numero { get; private set; }
        public string PIX { get; private set; }
        public double saldo { get; private set; }
        public Conta(Usuario usario,string senha,string titular, string numero, string PIX, double saldo)
        {
            this.usuario = usario;
            this.titular = titular;
            this.numero = numero;
            this.PIX = PIX;
            this.saldo = saldo;
            this.logs = new List<string>();
        }
        public void Log(string log)
        {
            this.logs.Add(log);
        }
        public bool depositar(double valor)
        {
            if(valor > 0)
            {
                this.saldo += valor;
                this.Log("Deposito realizado no valor de R$" + valor);
                return true;
            }
            this.logs.Add("Deposito cancelado");
            return false;
        }
        public bool saque(double valor)
        {
            if(this.saldo >= valor)
            {
                this.saldo -= valor;
                this.Log("Saque realizado no valor de R$" + valor);
                return true;
            }
            this.Log("Saque cancelado");
            return false;
        }
        public bool trasnferir(Conta conta, double valor)
        {
            if(valor > 0&& conta.saldo >= valor)
            {
                this.saldo -= valor;
                conta.saldo += valor;
                this.Log("Transferência feita entre contas do mesmo banco no valor de R$" + valor + " para " + conta.usuario.nome);
                return true;
            }
            return false;
        }
        public bool receberTransferencia(Conta conta, double valor)
        {
            if(conta.saldo >= valor)
            {
                this.saldo += valor;
                conta.saldo -= valor;
                this.Log("PIX recebido no valor de R$ " + valor + " de " + conta.usuario.nome);
                return true;
            }
            return false;
        }
    }
}
