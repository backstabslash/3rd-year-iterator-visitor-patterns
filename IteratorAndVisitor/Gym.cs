using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorAndVisitor
{
    public class Gym
    {
        public List<Person> Persons {  get; set; } = new List<Person>();
        public List<Equipment> Equipment { get; set; } = new List<Equipment>();
        public Gym(List<Person> Persons, List<Equipment> Equipment)
        {
            this.Persons = Persons;
            this.Equipment = Equipment;
        }
    }
    public class Person : PersonAcceptor
    {
        public string full_name { get; set; } = string.Empty;
        public int age { get; set; }
        public int weight { get; set; }
        public DateTime subscription_start {  get; set; }
        public int subscription_duration { get; set; }
        public Person(string full_name, int age, int weight, DateTime subscription_start, int subscription_duration)
        {
            this.full_name = full_name;
            this.age = age;
            this.weight = weight;
            this.subscription_start = subscription_start;
            this.subscription_duration = subscription_duration;
        }
    }
    public class Equipment : EquipmentAcceptor
    {
        public enum MuscleType
        {
            Chest,
            Back,
            Arms,
            Abdominals,
            Legs,
            Shoulders
        }
        public MuscleType muscle_type { get; set; }
        public string eq_name { get; set; } = string.Empty;
        public string weight_range { get; set; } = string.Empty;
        public Equipment(MuscleType muscle_type, string eq_name, string weight_range)
        {
            this.muscle_type = muscle_type;
            this.eq_name = eq_name;
            this.weight_range = weight_range;
        }
    }
}
