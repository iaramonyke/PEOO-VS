using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EscolaApp
{

	 class NProfessor
	{
		private static List<Professor> professor = new List<Professor>();

		public static void Inserir(Professor p)
        {
            Abrir();
            int id = 0;
            foreach (Professor obj in professor)
                if (obj.Id > id) id = obj.Id;
            p.Id = id + 1;
            professor.Add(p);
            Salvar();
        }

        public static void List<Professor>Listar()
        {
            Abrir();
            return professor;
        }

        public static void Excluir(Professor p)
        {
            Abrir();
            Professor y = null;
            foreach (Professor obj in professor)
                if (obj.Id == p.Id) y = obj;
            if (y != null) professor.Remove(y);
            Salvar();
        }

        public static void Atualizar(Professor p)
        {
            Abrir();
            foreach (Professor obj in professor)
                if (obj.Id == p.Id)
                {
                    obj.Nome = p.Nome;
                    obj.Matricula = p.Matricula;
                    obj.Area = p.Area;
                }
            Salvar();
        }

        public static void Abrir()
        {
            
        }


	}

