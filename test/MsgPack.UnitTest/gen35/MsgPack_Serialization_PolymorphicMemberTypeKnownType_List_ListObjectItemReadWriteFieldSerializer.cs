﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:2.0.50727.8745
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MsgPack.Serialization.GeneratedSerializers {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("MsgPack.Serialization.CodeDomSerializers.CodeDomSerializerBuilder", "0.9.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public class MsgPack_Serialization_PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteFieldSerializer : MsgPack.Serialization.MessagePackSerializer<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField> {
        
        private MsgPack.Serialization.MessagePackSerializer<System.Collections.Generic.IList<object>> _serializer0;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField>> _packOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField>> _packOperationTable;
        
        private System.Collections.Generic.IDictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField, bool>> _nullCheckersTable;
        
        private System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField, System.Collections.Generic.IList<object>> this_SetUnpackedValueOfListObjectItemDelegate;
        
        private System.Collections.Generic.IList<string> _memberNames;
        
        private System.Collections.Generic.IList<System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField, int, int>> _unpackOperationList;
        
        private System.Collections.Generic.IDictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField, int, int>> _unpackOperationTable;
        
        public MsgPack_Serialization_PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteFieldSerializer(MsgPack.Serialization.SerializationContext context) : 
                base(context, (MsgPack.Serialization.SerializerCapabilities.PackTo | MsgPack.Serialization.SerializerCapabilities.UnpackFrom)) {
            MsgPack.Serialization.PolymorphismSchema schema0 = default(MsgPack.Serialization.PolymorphismSchema);
            MsgPack.Serialization.PolymorphismSchema itemsSchema0 = default(MsgPack.Serialization.PolymorphismSchema);
            System.Collections.Generic.Dictionary<string, System.Type> itemsSchemaTypeMap0 = default(System.Collections.Generic.Dictionary<string, System.Type>);
            itemsSchemaTypeMap0 = new System.Collections.Generic.Dictionary<string, System.Type>(2);
            itemsSchemaTypeMap0.Add("0", typeof(MsgPack.Serialization.FileEntry));
            itemsSchemaTypeMap0.Add("1", typeof(MsgPack.Serialization.DirectoryEntry));
            itemsSchema0 = MsgPack.Serialization.PolymorphismSchema.ForPolymorphicObject(typeof(object), itemsSchemaTypeMap0);
            schema0 = MsgPack.Serialization.PolymorphismSchema.ForContextSpecifiedCollection(typeof(System.Collections.Generic.IList<object>), itemsSchema0);
            this._serializer0 = context.GetSerializer<System.Collections.Generic.IList<object>>(schema0);
            System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField>[] packOperationList = default(System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField>[]);
            packOperationList = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField>[1];
            packOperationList[0] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField>(this.PackValueOfListObjectItem);
            this._packOperationList = packOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField>> packOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField>>);
            packOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField>>(1);
            packOperationTable["ListObjectItem"] = new System.Action<MsgPack.Packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField>(this.PackValueOfListObjectItem);
            this._packOperationTable = packOperationTable;
            System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField, bool>> nullCheckerTable = default(System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField, bool>>);
            nullCheckerTable = new System.Collections.Generic.Dictionary<string, System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField, bool>>(1);
            nullCheckerTable["ListObjectItem"] = new System.Func<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField, bool>(this.IsListObjectItemNull);
            this._nullCheckersTable = nullCheckerTable;
            System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField, int, int>[] unpackOperationList = default(System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField, int, int>[]);
            unpackOperationList = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField, int, int>[1];
            unpackOperationList[0] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField, int, int>(this.UnpackValueOfListObjectItem);
            this._unpackOperationList = unpackOperationList;
            System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField, int, int>> unpackOperationTable = default(System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField, int, int>>);
            unpackOperationTable = new System.Collections.Generic.Dictionary<string, System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField, int, int>>(1);
            unpackOperationTable["ListObjectItem"] = new System.Action<MsgPack.Unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField, int, int>(this.UnpackValueOfListObjectItem);
            this._unpackOperationTable = unpackOperationTable;
            this._memberNames = new string[] {
                    "ListObjectItem"};
            this.this_SetUnpackedValueOfListObjectItemDelegate = new System.Action<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField, System.Collections.Generic.IList<object>>(this.SetUnpackedValueOfListObjectItem);
        }
        
        private void PackValueOfListObjectItem(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField objectTree) {
            this._serializer0.PackTo(packer, objectTree.ListObjectItem);
        }
        
        private bool IsListObjectItemNull(MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField objectTree) {
            return (objectTree.ListObjectItem == null);
        }
        
        protected internal override void PackToCore(MsgPack.Packer packer, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField objectTree) {
            MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField> packHelperParameters = default(MsgPack.Serialization.PackToArrayParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField>);
            packHelperParameters.Packer = packer;
            packHelperParameters.Target = objectTree;
            packHelperParameters.Operations = this._packOperationList;
            MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField> packHelperParameters0 = default(MsgPack.Serialization.PackToMapParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField>);
            packHelperParameters0.Packer = packer;
            packHelperParameters0.Target = objectTree;
            packHelperParameters0.Operations = this._packOperationTable;
            packHelperParameters0.SerializationContext = this.OwnerContext;
            packHelperParameters0.NullCheckers = this._nullCheckersTable;
            if ((this.OwnerContext.SerializationMethod == MsgPack.Serialization.SerializationMethod.Array)) {
                MsgPack.Serialization.PackHelpers.PackToArray(ref packHelperParameters);
            }
            else {
                MsgPack.Serialization.PackHelpers.PackToMap(ref packHelperParameters0);
            }
        }
        
        private void SetUnpackedValueOfListObjectItem(MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField unpackingContext, System.Collections.Generic.IList<object> unpackedValue) {
            unpackingContext.ListObjectItem = unpackedValue;
        }
        
        private void UnpackValueOfListObjectItem(MsgPack.Unpacker unpacker, MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField unpackingContext, int indexOfItem, int itemsCount) {
            MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField, System.Collections.Generic.IList<object>> unpackHelperParameters = default(MsgPack.Serialization.UnpackReferenceTypeValueParameters<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField, System.Collections.Generic.IList<object>>);
            unpackHelperParameters.Unpacker = unpacker;
            unpackHelperParameters.UnpackingContext = unpackingContext;
            unpackHelperParameters.Serializer = this._serializer0;
            unpackHelperParameters.ItemsCount = itemsCount;
            unpackHelperParameters.Unpacked = indexOfItem;
            unpackHelperParameters.TargetObjectType = typeof(System.Collections.Generic.IList<object>);
            unpackHelperParameters.MemberName = "ListObjectItem";
            unpackHelperParameters.NilImplication = MsgPack.Serialization.NilImplication.MemberDefault;
            unpackHelperParameters.DirectRead = null;
            unpackHelperParameters.Setter = this.this_SetUnpackedValueOfListObjectItemDelegate;
            MsgPack.Serialization.UnpackHelpers.UnpackReferenceTypeValue(ref unpackHelperParameters);
        }
        
        protected internal override MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField UnpackFromCore(MsgPack.Unpacker unpacker) {
            MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField result = default(MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField);
            result = new MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField();
            if (unpacker.IsArrayHeader) {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromArray(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField>(), this._memberNames, this._unpackOperationList);
            }
            else {
                return MsgPack.Serialization.UnpackHelpers.UnpackFromMap(unpacker, result, MsgPack.Serialization.UnpackHelpers.GetIdentity<MsgPack.Serialization.PolymorphicMemberTypeKnownType_List_ListObjectItemReadWriteField>(), this._unpackOperationTable);
            }
        }
    }
}
