// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: proxy.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace l2PushGrpc {

  /// <summary>Holder for reflection information generated from proxy.proto</summary>
  public static partial class ProxyReflection {

    #region Descriptor
    /// <summary>File descriptor for proxy.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProxyReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cgtwcm94eS5wcm90bxIQc2EucnBjLmNsaS5wcm94eRoMZW50aXR5LnByb3Rv",
            "IiwKA1JzcBIKCgJpZBgBIAEoCRIMCgRjb2RlGAIgASgFEgsKA21zZxgDIAEo",
            "CSJgCg9TdWJzY3JpcHRpb25Sc3ASIgoDcnNwGAEgASgLMhUuc2EucnBjLmNs",
            "aS5wcm94eS5Sc3ASKQoEZGF0YRgEIAEoCzIbLnNhLnJwYy5lbnRpdHkuU3Vi",
            "c2NyaXB0aW9uMqAECgVQcm94eRJLCg9HZXRTdWJzY3JpcHRpb24SEy5zYS5y",
            "cGMuZW50aXR5LlZvaWQaIS5zYS5ycGMuY2xpLnByb3h5LlN1YnNjcmlwdGlv",
            "blJzcCIAEkEKD0FkZFN1YnNjcmlwdGlvbhIVLnNhLnJwYy5lbnRpdHkuU3Ry",
            "aW5nGhUuc2EucnBjLmNsaS5wcm94eS5Sc3AiABJBCg9EZWxTdWJzY3JpcHRp",
            "b24SFS5zYS5ycGMuZW50aXR5LlN0cmluZxoVLnNhLnJwYy5jbGkucHJveHku",
            "UnNwIgASSQoTTmV3VGlja1JlY29yZFN0cmVhbRITLnNhLnJwYy5lbnRpdHku",
            "Vm9pZBoZLnNhLnJwYy5lbnRpdHkuVGlja1JlY29yZCIAMAESSwoUTmV3T3Jk",
            "ZXJSZWNvcmRTdHJlYW0SEy5zYS5ycGMuZW50aXR5LlZvaWQaGi5zYS5ycGMu",
            "ZW50aXR5Lk9yZGVyUmVjb3JkIgAwARJVChlOZXdPcmRlclF1ZXVlUmVjb3Jk",
            "U3RyZWFtEhMuc2EucnBjLmVudGl0eS5Wb2lkGh8uc2EucnBjLmVudGl0eS5P",
            "cmRlclF1ZXVlUmVjb3JkIgAwARJVChlOZXdTdG9ja1F1b3RlUmVjb3JkU3Ry",
            "ZWFtEhMuc2EucnBjLmVudGl0eS5Wb2lkGh8uc2EucnBjLmVudGl0eS5TdG9j",
            "a1F1b3RlUmVjb3JkIgAwAUIjWhRsMi1wdXNoLWdvL3JwYy9wcm94eaoCCmwy",
            "UHVzaEdycGNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::l2PushGrpc.EntityReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::l2PushGrpc.Rsp), global::l2PushGrpc.Rsp.Parser, new[]{ "Id", "Code", "Msg" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::l2PushGrpc.SubscriptionRsp), global::l2PushGrpc.SubscriptionRsp.Parser, new[]{ "Rsp", "Data" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Rsp : pb::IMessage<Rsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Rsp> _parser = new pb::MessageParser<Rsp>(() => new Rsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Rsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::l2PushGrpc.ProxyReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Rsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Rsp(Rsp other) : this() {
      id_ = other.id_;
      code_ = other.code_;
      msg_ = other.msg_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Rsp Clone() {
      return new Rsp(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    /// <summary>
    ///??????ID
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "code" field.</summary>
    public const int CodeFieldNumber = 2;
    private int code_;
    /// <summary>
    ///?????????,???????????????
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Code {
      get { return code_; }
      set {
        code_ = value;
      }
    }

    /// <summary>Field number for the "msg" field.</summary>
    public const int MsgFieldNumber = 3;
    private string msg_ = "";
    /// <summary>
    ///??????????????????????????????
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Msg {
      get { return msg_; }
      set {
        msg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Rsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Rsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Code != other.Code) return false;
      if (Msg != other.Msg) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Code != 0) hash ^= Code.GetHashCode();
      if (Msg.Length != 0) hash ^= Msg.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Code != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Code);
      }
      if (Msg.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Msg);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Code != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Code);
      }
      if (Msg.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Msg);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Code != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Code);
      }
      if (Msg.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Msg);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Rsp other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Code != 0) {
        Code = other.Code;
      }
      if (other.Msg.Length != 0) {
        Msg = other.Msg;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 16: {
            Code = input.ReadInt32();
            break;
          }
          case 26: {
            Msg = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 16: {
            Code = input.ReadInt32();
            break;
          }
          case 26: {
            Msg = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class SubscriptionRsp : pb::IMessage<SubscriptionRsp>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SubscriptionRsp> _parser = new pb::MessageParser<SubscriptionRsp>(() => new SubscriptionRsp());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<SubscriptionRsp> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::l2PushGrpc.ProxyReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SubscriptionRsp() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SubscriptionRsp(SubscriptionRsp other) : this() {
      rsp_ = other.rsp_ != null ? other.rsp_.Clone() : null;
      data_ = other.data_ != null ? other.data_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public SubscriptionRsp Clone() {
      return new SubscriptionRsp(this);
    }

    /// <summary>Field number for the "rsp" field.</summary>
    public const int RspFieldNumber = 1;
    private global::l2PushGrpc.Rsp rsp_;
    /// <summary>
    ///?????????
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::l2PushGrpc.Rsp Rsp {
      get { return rsp_; }
      set {
        rsp_ = value;
      }
    }

    /// <summary>Field number for the "data" field.</summary>
    public const int DataFieldNumber = 4;
    private global::l2PushGrpc.Subscription data_;
    /// <summary>
    ///????????????
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::l2PushGrpc.Subscription Data {
      get { return data_; }
      set {
        data_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as SubscriptionRsp);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(SubscriptionRsp other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Rsp, other.Rsp)) return false;
      if (!object.Equals(Data, other.Data)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (rsp_ != null) hash ^= Rsp.GetHashCode();
      if (data_ != null) hash ^= Data.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (rsp_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Rsp);
      }
      if (data_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Data);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (rsp_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Rsp);
      }
      if (data_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Data);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (rsp_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Rsp);
      }
      if (data_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Data);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(SubscriptionRsp other) {
      if (other == null) {
        return;
      }
      if (other.rsp_ != null) {
        if (rsp_ == null) {
          Rsp = new global::l2PushGrpc.Rsp();
        }
        Rsp.MergeFrom(other.Rsp);
      }
      if (other.data_ != null) {
        if (data_ == null) {
          Data = new global::l2PushGrpc.Subscription();
        }
        Data.MergeFrom(other.Data);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (rsp_ == null) {
              Rsp = new global::l2PushGrpc.Rsp();
            }
            input.ReadMessage(Rsp);
            break;
          }
          case 34: {
            if (data_ == null) {
              Data = new global::l2PushGrpc.Subscription();
            }
            input.ReadMessage(Data);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            if (rsp_ == null) {
              Rsp = new global::l2PushGrpc.Rsp();
            }
            input.ReadMessage(Rsp);
            break;
          }
          case 34: {
            if (data_ == null) {
              Data = new global::l2PushGrpc.Subscription();
            }
            input.ReadMessage(Data);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
