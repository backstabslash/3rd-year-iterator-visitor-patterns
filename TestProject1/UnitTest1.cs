using Microsoft.VisualStudio.TestTools.UnitTesting;
using IteratorAndVisitor;
using System.Xml;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private static Person p1 = new Person("Abc Bcd Cde", 15, 50, new DateTime(2022, 10, 20), 30);
        private static Person p2 = new Person("Def Efg Fgh", 22, 75, new DateTime(2022, 5, 20), 360);
        private static Person p3 = new Person("Ghi Hik Ikl", 18, 90, new DateTime(2022, 10, 20), 90);
        private static Person p4 = new Person("Klm Lmn Mno", 48, 80, new DateTime(2022, 10, 20), 90);

        private static Equipment e1 = new Equipment(Equipment.MuscleType.Abdominals, "Cable Machine", "5-80");
        private static Equipment e2 = new Equipment(Equipment.MuscleType.Arms, "Bicep Curl Machine", "0-100");
        private static Equipment e3 = new Equipment(Equipment.MuscleType.Legs, "Leg Press Machine", "0-300");
        private static Equipment e4 = new Equipment(Equipment.MuscleType.Chest, "Bench Press Machine", "0-300");
        private static Equipment e5 = new Equipment(Equipment.MuscleType.Back, "Assisted Pull-Up Machine", "None");
        private static Equipment e6 = new Equipment(Equipment.MuscleType.Arms, "Cables", "5-80");

        private static Gym gym = new Gym(new List<Person> { p1, p2, p3, p4 }, new List<Equipment> { e1, e2, e3, e4, e5, e6 });

        private static string xmlpath = "D:/ForGit/IteratorAndVisitor/Info.xml";
        private static string jsonpath = "D:/ForGit/IteratorAndVisitor/Info.json";

        [TestMethod]
        public void TestMethod1()
        {
            for (int i = 0; i < gym.Persons.Count; i++)
                Console.WriteLine(gym.Persons[i].full_name);
            for (int i = 0; i < gym.Equipment.Count; i++)
                Console.WriteLine(gym.Equipment[i].eq_name);
        }
        [TestMethod]
        public void TestMethod2()
        {
            List<object> everythingNeeded = new List<object>();
            everythingNeeded.AddRange(gym.Persons);
            everythingNeeded.AddRange(gym.Equipment);
            IIterator it = new ListIterator(everythingNeeded);
            int count = 0;
            while (it.HasNext())
            {
                Assert.AreEqual(it.Next(), everythingNeeded[count]);
                count++;
            }    
        }
        [TestMethod]
        public void TestMethod3()
        {
            List<object> everythingNeeded = new List<object>();
            everythingNeeded.AddRange(gym.Persons);
            everythingNeeded.AddRange(gym.Equipment);
            IIterator it = new ListIterator(everythingNeeded);
            MyVisitor visitor = new MyVisitor();

            while (it.HasNext())
            {
                var item = it.Next() as IAcceptor;
                item?.Accept(visitor);
            }
        }
        [TestMethod]
        public void TestMethod4()
        {
            using (XmlWriter writer = XmlWriter.Create(xmlpath))
                writer.WriteStartElement("List");

            List<object> everythingNeeded = new List<object>();
            everythingNeeded.AddRange(gym.Persons);
            everythingNeeded.AddRange(gym.Equipment);
            IIterator it = new ListIterator(everythingNeeded);
            XmlVisitor visitor = new XmlVisitor();

            while (it.HasNext())
            {
                var item = it.Next() as IAcceptor;
                item?.Accept(visitor);
            }
        }
        [TestMethod]
        public void TestMethod5()
        {
            if (File.Exists(jsonpath)) File.Delete(jsonpath);

            List<object> everythingNeeded = new List<object>();
            everythingNeeded.AddRange(gym.Persons);
            everythingNeeded.AddRange(gym.Equipment);
            IIterator it = new ListIterator(everythingNeeded);
            JsonVisitor visitor = new JsonVisitor();

            while (it.HasNext())
            {
                var item = it.Next() as IAcceptor;
                item?.Accept(visitor);
            }
        }
    }
}