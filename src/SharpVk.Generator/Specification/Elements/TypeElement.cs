﻿using System.Collections.Generic;

namespace SharpVk.Generator.Specification.Elements
{
    public class TypeElement
        : SpecElement
    {
        public TypeCategory Category;
        public string Requires;
        public string Parent;
        public bool IsReturnedOnly;
        public bool IsTypePointer;
        public string Extends;

        public List<MemberElement> Members = new List<MemberElement>();
    }
}