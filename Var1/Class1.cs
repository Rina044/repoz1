using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var1
{
    class Lessons
    {
        private DateTime _date_time;
        private Discipline _discipline;
        private Employee _employee;
        private Auditorium _auditorium;
        private Group _group;
        private Lesson _lesson;
        private LessonType _lesson_type;

        public DateTime dateTime
        {
            get { return _date_time; }
            set { _date_time = value; }
        }

        public Discipline discipline
        {
            get { return _discipline; }
            set { _discipline = value; }
        }
        
        public Employee employee
        {
            get { return _employee; }
            set { _employee = value;  }
        }

        public Auditorium auditorium
        {
            get { return _auditorium; }
            set { _auditorium = value; }
        }

        public Group group
        {
            get { return _group; }
            set { _group = value; }
        }

        public Lesson lesson
        {
            get { return _lesson; }
            set { _lesson = value; }
        }

        public LessonType lessonType
        {
            get { return _lesson_type; }
            set { _lesson_type = value; }
        }

        public Lessons(DateTime dateTime, Discipline discipline, Employee employee, Auditorium auditorium, Group group, Lesson lesson, LessonType lessonType)
        {
            _date_time = dateTime;
            _discipline = discipline;
            _employee = employee;
            _auditorium = auditorium;
            _group = group;
            _lesson = lesson;
            _lesson_type = lessonType;
        }

        public Lessons(Discipline discipline, Employee employee, Auditorium auditorium, Group group, Lesson lesson, LessonType lessonType)
        {
            _date_time = dateTime != default ? dateTime : DateTime.Now;
            _discipline = discipline;
            _employee = employee;
            _auditorium = auditorium;
            _group = group;
            _lesson = lesson;
            _lesson_type = lessonType;
        }
    }
}
