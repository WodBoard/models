// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: movement_record.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace movement_record {

  /// <summary>Holder for reflection information generated from movement_record.proto</summary>
  public static partial class MovementRecordReflection {

    #region Descriptor
    /// <summary>File descriptor for movement_record.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MovementRecordReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVtb3ZlbWVudF9yZWNvcmQucHJvdG8SD21vdmVtZW50X3JlY29yZBofZ29v",
            "Z2xlL3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byJYCg5Nb3ZlbWVudFJlY29y",
            "ZBIMCgRuYW1lGAEgASgJEigKBGRhdGUYAiABKAsyGi5nb29nbGUucHJvdG9i",
            "dWYuVGltZXN0YW1wEg4KBndlaWdodBgDIAEoAUIjWg9tb3ZlbWVudF9yZWNv",
            "cmSqAg9tb3ZlbWVudF9yZWNvcmRiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::movement_record.MovementRecord), global::movement_record.MovementRecord.Parser, new[]{ "Name", "Date", "Weight" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class MovementRecord : pb::IMessage<MovementRecord> {
    private static readonly pb::MessageParser<MovementRecord> _parser = new pb::MessageParser<MovementRecord>(() => new MovementRecord());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<MovementRecord> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::movement_record.MovementRecordReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MovementRecord() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MovementRecord(MovementRecord other) : this() {
      name_ = other.name_;
      date_ = other.date_ != null ? other.date_.Clone() : null;
      weight_ = other.weight_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public MovementRecord Clone() {
      return new MovementRecord(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "date" field.</summary>
    public const int DateFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp date_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp Date {
      get { return date_; }
      set {
        date_ = value;
      }
    }

    /// <summary>Field number for the "weight" field.</summary>
    public const int WeightFieldNumber = 3;
    private double weight_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Weight {
      get { return weight_; }
      set {
        weight_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as MovementRecord);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(MovementRecord other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (!object.Equals(Date, other.Date)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Weight, other.Weight)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (date_ != null) hash ^= Date.GetHashCode();
      if (Weight != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Weight);
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (date_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Date);
      }
      if (Weight != 0D) {
        output.WriteRawTag(25);
        output.WriteDouble(Weight);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (date_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Date);
      }
      if (Weight != 0D) {
        size += 1 + 8;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(MovementRecord other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.date_ != null) {
        if (date_ == null) {
          date_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        Date.MergeFrom(other.Date);
      }
      if (other.Weight != 0D) {
        Weight = other.Weight;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            if (date_ == null) {
              date_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(date_);
            break;
          }
          case 25: {
            Weight = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
