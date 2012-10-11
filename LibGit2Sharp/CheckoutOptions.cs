using LibGit2Sharp.Core;

namespace LibGit2Sharp
{
    public enum CheckoutStrategy
    {
        Default = 1 << 0,
        OverwriteModified = 1 << 1,
        CreateMissing = 1 << 2,
        RemoveUntracked = 1 << 3,
    }
    
    public class CheckoutOptions
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public CheckoutOptions()
        {
            checkoutOptions = new GitCheckoutOptions();
            CheckoutStrategy =
                CheckoutStrategy.Default | 
                CheckoutStrategy.CreateMissing;
        }

        /// <summary>
        /// Strategy options for checkout
        /// </summary>
        public CheckoutStrategy CheckoutStrategy
        {
            get { return (CheckoutStrategy)checkoutOptions.CheckoutStrategy; }
            set { checkoutOptions.CheckoutStrategy = (uint) value; }
        }

        /// <summary>
        /// If true, disable filters for checkout
        /// </summary>
        public bool DisableFilters
        {
            get { return checkoutOptions.DisableFilters != 0; }
            set { checkoutOptions.DisableFilters = value ? 1 : 0; }
        }

        /// <summary>
        /// Creation mode for directories
        /// </summary>
        public int DirectoryMode
        {
            get { return checkoutOptions.DirMode; }
            set { checkoutOptions.DirMode = value; }
        }

        /// <summary>
        /// Creation mode for files
        /// </summary>
        public int FileMode
        {
            get { return checkoutOptions.FileMode; }
            set { checkoutOptions.FileMode = value; }
        }

        /// <summary>
        /// Flags to pass as the second parameter to open()
        /// </summary>
        public int FileOpenFlags
        {
            get { return checkoutOptions.FileOpenFlags; }
            set { checkoutOptions.FileOpenFlags = value; }
        }

        #region Fields

        internal GitCheckoutOptions checkoutOptions;

        #endregion
    }
}