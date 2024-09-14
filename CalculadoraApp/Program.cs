using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculadoraApp
{
    public class Calculadora
    {
        private List<string> _historico = new List<string>();

        public int Soma(int a, int b)
        {
            int resultado = a + b;
            AdicionaAoHistorico($"Soma({a}, {b}) = {resultado}");
            return resultado;
        }

        public int Subtrai(int a, int b)
        {
            int resultado = a - b;
            AdicionaAoHistorico($"Subtrai({a}, {b}) = {resultado}");
            return resultado;
        }

        public int Multiplica(int a, int b)
        {
            int resultado = a * b;
            AdicionaAoHistorico($"Multiplica({a}, {b}) = {resultado}");
            return resultado;
        }

        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Não é possível dividir por zero.");
            }
            int resultado = a / b;
            AdicionaAoHistorico($"Divide({a}, {b}) = {resultado}");
            return resultado;
        }

        private void AdicionaAoHistorico(string operacao)
        {
            _historico.Add(operacao);
            if (_historico.Count > 3)
            {
                _historico.RemoveAt(0);
            }
        }

        public List<string> Historico()
        {
            return _historico;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var calculadora = new Calculadora();
            
            Console.WriteLine($"Soma: {calculadora.Soma(10, 5)}");
            Console.WriteLine($"Subtração: {calculadora.Subtrai(10, 5)}");
            Console.WriteLine($"Multiplicação: {calculadora.Multiplica(10, 5)}");
            Console.WriteLine($"Divisão: {calculadora.Divide(10, 5)}");
            
            Console.WriteLine("Histórico das últimas operações:");
            foreach (var operacao in calculadora.Historico())
            {
                Console.WriteLine(operacao);
            }
        }
    }
}
