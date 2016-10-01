using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef4FileSystem.Model
{
    class FileSystemException : Exception
    {
        public string ErrorReason { get; set; }
        public FileSystemException(string ErrorFault)
        {
            ErrorReason = ErrorFault;
        }
    }
}
