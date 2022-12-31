using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace H8E3_BelieveNotBelieve.Models
{
    public class TrueFalse
    {
        private string _fileName;
        private List<Question> _list;

        public int Count => _list.Count;

        public TrueFalse(string fileName)
        {
            _fileName = fileName;
            _list = new List<Question>();
        }

        public void Add(string text, bool trueFalse)
        {
            var question = new Question(text, trueFalse);
            _list.Add(question);
        }

        public void Remove(int index)
        {
            if (_list.Any() && index < _list.Count && index >= 0)
            {
                _list.RemoveAt(index);
            }
        }

        public Question this[int index]
        {
            get => _list[index];
        }

        public void Save()
        {
            var serializer = new XmlSerializer(typeof(List<Question>));
            using(var stream = new FileStream(_fileName, FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, _list);
            }
        }

        public void Load()
        {
            var serializer = new XmlSerializer(typeof(List<Question>));
            using (var stream = new FileStream(_fileName, FileMode.Open))
            {
                _list = (List<Question>) serializer.Deserialize(stream);
            }
        }
    }
}