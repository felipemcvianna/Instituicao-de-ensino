using Primeiroprojeto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoInstituicaoDeEnsino
{
    public class Graduacao : Curso
    {
        public int Semestres { get; set; }
        public Graduacao(string nome, int cargahoraria, int semestres)
        {
            Nome = nome;
            CargaHoraria = cargahoraria;
            Semestres = semestres;
        }
        public override void RegistrarDisciplinas(Disciplina disciplina)
        {
            try
            {
                if (Disciplinas.Count >= 25) { throw new ArgumentException("todas as disciplinas já foram preenchidas!"); }
                Disciplinas.Add(disciplina);
            }
            catch(ArgumentException arg)
            {
                Console.WriteLine("Ocorreu um erro ao registrar as disciplinas: " + arg.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ocorreu um erro inexperado: " + ex.Message);
            }
            
        }
    }
}
