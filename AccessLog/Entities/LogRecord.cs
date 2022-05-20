namespace AccessLog.Entities
{
    public class LogRecord
    {
        public string? Username { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode() => Username.GetHashCode();

        public override bool Equals(object? obj)
        {
            if (obj is not LogRecord)
                return false;

            LogRecord? other = obj as LogRecord;

            return Username.Equals(other.Username);
        }
    }
}