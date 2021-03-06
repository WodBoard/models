// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: training.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace training {

  /// <summary>Holder for reflection information generated from training.proto</summary>
  public static partial class TrainingReflection {

    #region Descriptor
    /// <summary>File descriptor for training.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TrainingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cg50cmFpbmluZy5wcm90bxIIdHJhaW5pbmcifAoIVHJhaW5pbmcSDAoEbmFt",
            "ZRgBIAEoCRIMCgRkYXRlGAIgASgJEiQKBHR5cGUYAyABKA4yFi50cmFpbmlu",
            "Zy5UcmFpbmluZ1R5cGUSEAoIdGltZV9jYXAYBCABKAUSDQoFc2NvcmUYBSAB",
            "KAkSDQoFbm90ZXMYBiABKAkiJQoVRGVsZXRlVHJhaW5pbmdSZXF1ZXN0EgwK",
            "BG5hbWUYASABKAkqaAoMVHJhaW5pbmdUeXBlEg0KCVVOREVGSU5FRBAAEgwK",
            "CEZPUl9USU1FEAESCQoFQU1SQVAQAhIICgRFTU9NEAMSCgoGVEFCQVRBEAQS",
            "DwoLRk9SX1FVQUxJVFkQBRIJCgVBRlJBUBAGQhVaCHRyYWluaW5nqgIIdHJh",
            "aW5pbmdiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::training.TrainingType), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::training.Training), global::training.Training.Parser, new[]{ "Name", "Date", "Type", "TimeCap", "Score", "Notes" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::training.DeleteTrainingRequest), global::training.DeleteTrainingRequest.Parser, new[]{ "Name" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum TrainingType {
    [pbr::OriginalName("UNDEFINED")] Undefined = 0,
    [pbr::OriginalName("FOR_TIME")] ForTime = 1,
    [pbr::OriginalName("AMRAP")] Amrap = 2,
    [pbr::OriginalName("EMOM")] Emom = 3,
    [pbr::OriginalName("TABATA")] Tabata = 4,
    [pbr::OriginalName("FOR_QUALITY")] ForQuality = 5,
    [pbr::OriginalName("AFRAP")] Afrap = 6,
  }

  #endregion

  #region Messages
  public sealed partial class Training : pb::IMessage<Training> {
    private static readonly pb::MessageParser<Training> _parser = new pb::MessageParser<Training>(() => new Training());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Training> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::training.TrainingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Training() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Training(Training other) : this() {
      name_ = other.name_;
      date_ = other.date_;
      type_ = other.type_;
      timeCap_ = other.timeCap_;
      score_ = other.score_;
      notes_ = other.notes_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Training Clone() {
      return new Training(this);
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
    private string date_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Date {
      get { return date_; }
      set {
        date_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 3;
    private global::training.TrainingType type_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::training.TrainingType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "time_cap" field.</summary>
    public const int TimeCapFieldNumber = 4;
    private int timeCap_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TimeCap {
      get { return timeCap_; }
      set {
        timeCap_ = value;
      }
    }

    /// <summary>Field number for the "score" field.</summary>
    public const int ScoreFieldNumber = 5;
    private string score_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Score {
      get { return score_; }
      set {
        score_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "notes" field.</summary>
    public const int NotesFieldNumber = 6;
    private string notes_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Notes {
      get { return notes_; }
      set {
        notes_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Training);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Training other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Date != other.Date) return false;
      if (Type != other.Type) return false;
      if (TimeCap != other.TimeCap) return false;
      if (Score != other.Score) return false;
      if (Notes != other.Notes) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Date.Length != 0) hash ^= Date.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      if (TimeCap != 0) hash ^= TimeCap.GetHashCode();
      if (Score.Length != 0) hash ^= Score.GetHashCode();
      if (Notes.Length != 0) hash ^= Notes.GetHashCode();
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
      if (Date.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Date);
      }
      if (Type != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Type);
      }
      if (TimeCap != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(TimeCap);
      }
      if (Score.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Score);
      }
      if (Notes.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Notes);
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
      if (Date.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Date);
      }
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      if (TimeCap != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TimeCap);
      }
      if (Score.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Score);
      }
      if (Notes.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Notes);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Training other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Date.Length != 0) {
        Date = other.Date;
      }
      if (other.Type != 0) {
        Type = other.Type;
      }
      if (other.TimeCap != 0) {
        TimeCap = other.TimeCap;
      }
      if (other.Score.Length != 0) {
        Score = other.Score;
      }
      if (other.Notes.Length != 0) {
        Notes = other.Notes;
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
            Date = input.ReadString();
            break;
          }
          case 24: {
            type_ = (global::training.TrainingType) input.ReadEnum();
            break;
          }
          case 32: {
            TimeCap = input.ReadInt32();
            break;
          }
          case 42: {
            Score = input.ReadString();
            break;
          }
          case 50: {
            Notes = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class DeleteTrainingRequest : pb::IMessage<DeleteTrainingRequest> {
    private static readonly pb::MessageParser<DeleteTrainingRequest> _parser = new pb::MessageParser<DeleteTrainingRequest>(() => new DeleteTrainingRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DeleteTrainingRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::training.TrainingReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeleteTrainingRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeleteTrainingRequest(DeleteTrainingRequest other) : this() {
      name_ = other.name_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DeleteTrainingRequest Clone() {
      return new DeleteTrainingRequest(this);
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

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DeleteTrainingRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DeleteTrainingRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(DeleteTrainingRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
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
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
