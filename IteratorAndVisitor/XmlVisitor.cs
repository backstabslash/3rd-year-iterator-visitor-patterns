using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace IteratorAndVisitor
{
    public class XmlVisitor : IVisitor
    {
        const string path = "D:/ForGit/IteratorAndVisitor/Info.xml";
        private static XDocument doc = XDocument.Load(path);
        private XElement? list = doc.Element("List");
        public void Visit(PersonAcceptor item)
        {
            var person = item as Person;
            list?.Add(new XElement("Person", 
                new XElement("Fullname", person.full_name),
                new XElement("Age", person.age),
                new XElement("Weight", person.weight),
                new XElement("SubscriptionStart", person.subscription_start),
                new XElement("SubscriptionDuration", person.subscription_duration)));
            doc.Save(path);
        }
        public void Visit(EquipmentAcceptor item)
        {
            var equipment = item as Equipment;
            list?.Add(new XElement("Equipment",
                new XElement("Equipment", equipment.eq_name),
                new XElement("MuscleGroup", equipment.muscle_type),
                new XElement("WeightRange", equipment.weight_range)));
            doc.Save(path);
        }
    }
}
