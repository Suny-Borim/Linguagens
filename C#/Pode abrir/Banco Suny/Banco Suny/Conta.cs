using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Suny
{
    internal class Conta
    {
        public int agencia;
        public double saldo;
        public Cliente cliente;
        public Conta(int agencia, double saldo, Cliente cliente)
        {
            this.agencia = agencia;
            this.saldo = saldo;
            this.cliente = cliente;
        }

        public void exibir(Cliente cliente)
        {
            Console.WriteLine(
                "//----------/" +
                "/\n titular:{0}\n cpf:{1}\n agencia: {2}\n Banco: {3}\n saldo:{4} \n" +
                "//----------//",cliente.nome, cliente.cpf,this.agencia, cliente.Banco, this.saldo);
        }
        public void saque(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo -= valor;
            }
            else Console.WriteLine("Saldo insuficiente");
        }
        public void depositar(double valor)
        {
            this.saldo += valor;
        }
        public void transferir(Conta conta, double valor)
        {
            if (this.saldo >= valor)
            {
                this.saque(valor);
                conta.depositar(valor);
            }
            else Console.WriteLine("Seu saldo atual é {0}\n operação cancelada", this.saldo);
        }
    }
}
