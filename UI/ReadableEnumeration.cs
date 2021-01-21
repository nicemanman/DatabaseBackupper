using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI
{
    public class ReadableEnumerationValue 
    {
        public ReadableEnumerationValue(string Name, Enum EnumerationItem)
        {
            this.Name = Name;
            this.EnumerationItem = EnumerationItem;
        }
        public string Name { get; protected set; }
        public Enum EnumerationItem { get; protected set; }
    }
    public class ReadableEnumeration
    {
        private readonly List<ReadableEnumerationValue> UIEnumerationValues;
        public ReadableEnumeration(List<string> readableNames, List<Enum> enumerationNames)
        {
            UIEnumerationValues = new List<ReadableEnumerationValue>();
            SetReadableList(readableNames, enumerationNames);
        }

        public Enum GetSelectedEnum(string readableName)
        {
            return UIEnumerationValues.Where(x => x.Name == readableName).Select(x => x.EnumerationItem).FirstOrDefault();
        }

        public List<string> GetReadableList()
        {
            return UIEnumerationValues.Select(x => x.Name).ToList();
        }

        private void SetReadableList(List<string> readableList, List<Enum> enumList)
        {
            if (readableList.Count() != enumList.Count()) throw new Exception("Размеры читаемого списка и перечисления не равны!");
            int index = 0;
            while (index != readableList.Count()) 
            {
                var value = new ReadableEnumerationValue(readableList[index], enumList[index]);
                UIEnumerationValues.Add(value);
                index++;
            }
        }
    }
}
