using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42ComputerClass
{
    class Computer
    {
        /// <summary>
        /// Processor speed in Hz
        /// </summary>
        public int ProcessorSpeed { get; set; }


        private int _ram;
        /// <summary>
        /// RAM capacity in bytes
        /// </summary>
        public int Ram
        {
            get
            {
                return _ram;
            }

            set
            {
                _ram = value + value % 2;
            }
        }


        private long _disk;
        /// <summary>
        /// Disk capacity in bytes.
        /// </summary>
        public long Disk
        {
            get
            {
                return _disk;
            }
            set
            {
                _disk = value + (int)(value) % 2;
            }
        }

        public Computer(int cpu, int ram)
        {
            this.ProcessorSpeed = cpu;
            this.Ram = ram;
        }

        public int PerformOperation(int operationAmount)
        {
            if (operationAmount > Ram)
            {
                return 0;
            }

            return operationAmount / ProcessorSpeed;
        }

        public bool WriteToDisk(string dataToWrite)
        {
            long size = dataToWrite.Length;
            if (Disk > size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
