namespace OnlineCoursePortal.Entities
{
    public class Student
    {
        public int Id { get; set; }

        public override int GetHashCode() => Id.GetHashCode();

        public override bool Equals(object? obj)
        {
            if (obj is not Student)
                return false;

            Student? other = obj as Student;

            return Id.Equals(other.Id);
        }
    }
}