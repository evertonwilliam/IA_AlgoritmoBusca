using IA_AlgoritmoBusca.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_AlgoritmoBusca.extruct
{
    internal class Pilha
    {
        private int tamanho;
        private Cidade[] cidades;
        private int topo;

        public Pilha(int tamanho)
        {
            this.tamanho = tamanho;
            cidades = new Cidade[this.tamanho];
            topo = -1;
        }

        public void Empilhar(Cidade cidade)
        {
            if (!PilhaCheia())
            {
                this.cidades[++topo] = cidade;
            }
            else
            {
                throw new Exception("A pilha já está cheia");
            }
        }

        public Cidade Desempilhar()
        {
            if (!PilhaVazia())
            {
                this.cidades[topo] = null;
                return cidades[topo--];
            }
            else
            {
                throw new Exception("A pilha já está vazia");
            }
        }

        public Cidade GetTopo()
        {
            return cidades[topo];
        }

        private Boolean PilhaVazia()
        {
            return (topo == -1);
        }

        private Boolean PilhaCheia()
        {
            return (topo == tamanho - 1);
        }

        public Cidade[] GetPilha()
        {
            return cidades;
        }

    }
}
