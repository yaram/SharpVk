﻿using SharpVk.Spirv;

namespace SharpVk.Shanq
{
    public abstract class Pointer<T>
    {
        public Pointer(T value)
        {
            this.Value = value;
        }

        public T Value
        {
            get;
            private set;
        }
    }

    public class OutputPointer<T>
        : Pointer<T>
    {
        public OutputPointer(T value)
            : base(value)
        {
        }

        public static StorageClass Storage => StorageClass.Output;
    }

    public class InputPointer<T>
        : Pointer<T>
    {
        public InputPointer(T value)
            : base(value)
        {
        }

        public static StorageClass Storage => StorageClass.Input;
    }

    public class UniformPointer<T>
        : Pointer<T>
    {
        public UniformPointer(T value)
            : base(value)
        {
        }

        public static StorageClass Storage => StorageClass.Uniform;
    }
}
