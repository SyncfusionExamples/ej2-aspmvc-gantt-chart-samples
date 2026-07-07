namespace RemoteSaveAdaptor.Server.Model
{
    public class GanttTask
    {
        public int? TaskId { get; set; }
        public string? TaskName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? Duration { get; set; }
        public int? Progress { get; set; }
        public int? ParentId { get; set; }
    }
}
