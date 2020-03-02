using System;

namespace Homework4.Aids {

    public interface ILogBook {
        void WriteEntry(string message);

        void WriteEntry(Exception e);
    }

}


