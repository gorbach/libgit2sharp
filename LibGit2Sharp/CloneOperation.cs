namespace LibGit2Sharp
{
    public class CloneOperation
    {
        public delegate void ProgressHandler(string message);

        /// <summary>
        /// Controls the maximum rate at which the Progress callback can be
        /// triggered. Set to 0 (or set Progress to null) to disable. 
        /// Defaults to 100.
        /// </summary>
        public uint PollIntervalInMilliseconds { get; set; }

        public string SourceUrl { get; private set; }
        public string DestinationPath { get; private set; }
        public bool Bare { get; set; }
        public bool Checkout { get; set; }

        public ProgressHandler Progress { get; set; }

        public CloneOperation(string sourceUrl, string workdirPath)
        {
            SourceUrl = sourceUrl;
            DestinationPath = workdirPath;
            Bare = false;
            Checkout = true;
            PollIntervalInMilliseconds = 100;
        }

        /// <summary>
        /// Starts a clone operation on a background thread, and polls for 
        /// progress on this thread.
        /// </summary>
        /// <returns></returns>
        public virtual Repository Execute()
        {
            // TODO
            return Repository.Init(DestinationPath, Bare);
        }
    }
}