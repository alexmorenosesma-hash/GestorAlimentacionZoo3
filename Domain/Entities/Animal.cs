using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Animal
    {
        public string idAnimal { get; set; }
        public string nombre { get; set; }
        public int edad { get; set; }
        public int peso { get; set; }
        public string salud { get; set; }
        public string especie { get; set; }
        public string dieta {get;set; }
        public List<Horario> horariosAlimentacion{get;set; }
        public Animal()
        {
        }
        public Animal(int edad, int peso, string salud, string especie, string dieta, List<Horario> horariosAlimentacion)
        {
            this.edad = edad;
            this.peso = peso;
            this.salud = salud;
            this.especie = especie;
            this.dieta = dieta;
            this.horariosAlimentacion = horariosAlimentacion;
        }
    }
}
