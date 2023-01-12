using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace IteratorAndVisitor
{
    public class JsonVisitor : IVisitor
    {
        const string path = "D:/ForGit/IteratorAndVisitor/Info.json";
        public void Visit(PersonAcceptor item)
        {
            var person = item as Person;
            if (!File.Exists(path))
                File.WriteAllText(path, JsonSerializer.Serialize(person, new JsonSerializerOptions { WriteIndented = true }));
            else File.AppendAllText(path, JsonSerializer.Serialize(person, new JsonSerializerOptions { WriteIndented = true }));
        }
        public void Visit(EquipmentAcceptor item)
        {
            var equipment = item as Equipment;
            if (!File.Exists(path))
                File.WriteAllText(path, JsonSerializer.Serialize(equipment, new JsonSerializerOptions { WriteIndented = true }));
            else File.AppendAllText(path, JsonSerializer.Serialize(equipment, new JsonSerializerOptions { WriteIndented = true }));
        }
    }
}
