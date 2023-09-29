﻿using CUE4Parse.UE4.Assets.Readers;
using CUE4Parse.Utils;
using Newtonsoft.Json;

namespace CUE4Parse.UE4.Assets.Objects.Properties
{
    [JsonConverter(typeof(StructPropertyConverter))]
    public class StructProperty : FPropertyTagType<UScriptStruct>
    {
        public StructProperty(FAssetArchive Ar, FPropertyTagData? tagData, ReadType type)
        {
            Value = new UScriptStruct(Ar, tagData?.StructType, tagData?.Struct, type);
        }

        public override string ToString() => Value.ToString().SubstringBeforeLast(')') + ", StructProperty)";
    }
}
