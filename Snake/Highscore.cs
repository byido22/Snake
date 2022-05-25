using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    [Serializable]
    class Highscore : ISerializable

    {
        public int _highScore;
        public string _Name;
        public Highscore()
        {
            _Name = "stam";
            _highScore = 0;
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Name", _Name);
            info.AddValue("Highscore", _highScore);
        }
        public Highscore(SerializationInfo info, StreamingContext context)
        {
            _Name = (string)info.GetValue("Name", typeof(string));
            _highScore = (int)info.GetValue("Highscore", typeof(int));
        }
    }
}
