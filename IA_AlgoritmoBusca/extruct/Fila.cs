using IA_AlgoritmoBusca.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_AlgoritmoBusca.extruct
{
    internal class Fila
    {
        private readonly int tamanho;
        private readonly Cidade[] cidades;
        private int inicio;
        private int fim;
        private int numeroElementos;

        public Fila(int tamanho)
        {
            this.tamanho = tamanho;
            cidades = new Cidade[tamanho];
            inicio = 0;
            fim = 0;
            numeroElementos = 0;
        }

        public void Enfileirar(Cidade cidade)
        {
            if (!FilaCheia())
            {
                if (this.fim == tamanho - 1)
                {
                    this.fim = -1;
                }
                this.cidades[++fim] = cidade;
                numeroElementos++;
            }
            else
            {
                throw new Exception("A fila já está cheia");
            }
        }

        public Cidade Desenfileirar()
        {
            if (!FilaVazia())
            {
                Cidade temp = cidades[inicio++];
                if (inicio == tamanho)
                {
                    inicio = 0;
                }
                numeroElementos--;
                return temp;
            }
            else
            {
                throw new Exception("A fila já está fazia");
            }
        }

        public Cidade GetPrimeiro()
        {
            return cidades[inicio];
        }

        public Boolean FilaVazia()
        {
            return (numeroElementos == 0);
        }

        public Boolean FilaCheia()
        {
            return (numeroElementos == tamanho);
        }

        public int GetNumeroElementos()
        {
            return numeroElementos;
        }
    }
}
