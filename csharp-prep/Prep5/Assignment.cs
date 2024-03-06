using System;

namespace program
{
    public class Assignment
    {
        protected string _studentName = "";
        protected string _topic = "";

        public string GetstudentName(){
            return _studentName;
        }
        public void SetStudentName(string name){
            _studentName = name;
        }

        public string GetTopic(){
            return _topic;
        }
        public void SetTopic(string topic){
            _topic = topic;
        }

        public string  GetSummary(){
            return $"{_studentName} - {_topic}";
        }
    }
}