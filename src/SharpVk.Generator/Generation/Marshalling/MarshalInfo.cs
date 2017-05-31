﻿using SharpVk.Emit;
using System;

namespace SharpVk.Generator.Generation.Marshalling
{
    public struct MarshalInfo
    {
        public string MemberType;
        public string InteropType;
        public AssignActionType MarshalToActionType;
        public AssignActionType MarshalFromActionType;
        public Func<Action<ExpressionBuilder>, Action<ExpressionBuilder>> BuildMarshalToValueExpression;
        public Func<Action<ExpressionBuilder>, Action<ExpressionBuilder>> BuildMarshalFromValueExpression;
    }
}
