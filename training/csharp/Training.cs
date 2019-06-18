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
            "Cg50cmFpbmluZy5wcm90bxIIdHJhaW5pbmciQgoIRXhlcmNpc2USKAoIbW92",
            "ZW1lbnQYASABKA4yFi50cmFpbmluZy5Nb3ZlbWVudFR5cGUSDAoEbmFtZRgC",
            "IAEoCSJ3CghUcmFpbmluZxIMCgRuYW1lGAEgASgJEiQKBHR5cGUYAiABKA4y",
            "Fi50cmFpbmluZy5UcmFpbmluZ1R5cGUSJQoJZXhlcmNpc2VzGAMgAygLMhIu",
            "dHJhaW5pbmcuRXhlcmNpc2USEAoIdGltZV9jYXAYBCABKAUiJQoVRGVsZXRl",
            "VHJhaW5pbmdSZXF1ZXN0EgwKBG5hbWUYASABKAkqNgoMTW92ZW1lbnRUeXBl",
            "EhEKDVdFSUdIVExJRlRJTkcQABIHCgNHWU0QARIKCgZDQVJESU8QAipZCgxU",
            "cmFpbmluZ1R5cGUSDAoIRk9SX1RJTUUQABIJCgVBTVJBUBABEggKBEVNT00Q",
            "AhIKCgZUQUJBVEEQAxIPCgtGT1JfUVVBTElUWRAEEgkKBUFGU0FQEAVCFVoI",
            "dHJhaW5pbmeqAgh0cmFpbmluZ2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::training.MovementType), typeof(global::training.TrainingType), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::training.Exercise), global::training.Exercise.Parser, new[]{ "Movement", "Name" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::training.Training), global::training.Training.Parser, new[]{ "Name", "Type", "Exercises", "TimeCap" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::training.DeleteTrainingRequest), global::training.DeleteTrainingRequest.Parser, new[]{ "Name" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum MovementType {
    [pbr::OriginalName("WEIGHTLIFTING")] Weightlifting = 0,
    [pbr::OriginalName("GYM")] Gym = 1,
    [pbr::OriginalName("CARDIO")] Cardio = 2,
  }

  public enum TrainingType {
    [pbr::OriginalName("FOR_TIME")] ForTime = 0,
    [pbr::OriginalName("AMRAP")] Amrap = 1,
    [pbr::OriginalName("EMOM")] Emom = 2,
    [pbr::OriginalName("TABATA")] Tabata = 3,
    [pbr::OriginalName("FOR_QUALITY")] ForQuality = 4,
    [pbr::OriginalName("AFSAP")] Afsap = 5,
  }

  #endregion

  #region Messages
  public sealed partial class Exercise : pb::IMessage<Exercise> {
    private static readonly pb::MessageParser<Exercise> _parser = new pb::MessageParser<Exercise>(() => new Exercise());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Exercise> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::training.TrainingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Exercise() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Exercise(Exercise other) : this() {
      movement_ = other.movement_;
      name_ = other.name_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Exercise Clone() {
      return new Exercise(this);
    }

    /// <summary>Field number for the "movement" field.</summary>
    public const int MovementFieldNumber = 1;
    private global::training.MovementType movement_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::training.MovementType Movement {
      get { return movement_; }
      set {
        movement_ = value;
      }
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 2;
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
      return Equals(other as Exercise);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Exercise other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Movement != other.Movement) return false;
      if (Name != other.Name) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Movement != 0) hash ^= Movement.GetHashCode();
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
      if (Movement != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Movement);
      }
      if (Name.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Movement != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Movement);
      }
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Exercise other) {
      if (other == null) {
        return;
      }
      if (other.Movement != 0) {
        Movement = other.Movement;
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
          case 8: {
            movement_ = (global::training.MovementType) input.ReadEnum();
            break;
          }
          case 18: {
            Name = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Training : pb::IMessage<Training> {
    private static readonly pb::MessageParser<Training> _parser = new pb::MessageParser<Training>(() => new Training());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Training> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::training.TrainingReflection.Descriptor.MessageTypes[1]; }
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
      type_ = other.type_;
      exercises_ = other.exercises_.Clone();
      timeCap_ = other.timeCap_;
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

    /// <summary>Field number for the "type" field.</summary>
    public const int TypeFieldNumber = 2;
    private global::training.TrainingType type_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::training.TrainingType Type {
      get { return type_; }
      set {
        type_ = value;
      }
    }

    /// <summary>Field number for the "exercises" field.</summary>
    public const int ExercisesFieldNumber = 3;
    private static readonly pb::FieldCodec<global::training.Exercise> _repeated_exercises_codec
        = pb::FieldCodec.ForMessage(26, global::training.Exercise.Parser);
    private readonly pbc::RepeatedField<global::training.Exercise> exercises_ = new pbc::RepeatedField<global::training.Exercise>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::training.Exercise> Exercises {
      get { return exercises_; }
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
      if (Type != other.Type) return false;
      if(!exercises_.Equals(other.exercises_)) return false;
      if (TimeCap != other.TimeCap) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Type != 0) hash ^= Type.GetHashCode();
      hash ^= exercises_.GetHashCode();
      if (TimeCap != 0) hash ^= TimeCap.GetHashCode();
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
      if (Type != 0) {
        output.WriteRawTag(16);
        output.WriteEnum((int) Type);
      }
      exercises_.WriteTo(output, _repeated_exercises_codec);
      if (TimeCap != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(TimeCap);
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
      if (Type != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Type);
      }
      size += exercises_.CalculateSize(_repeated_exercises_codec);
      if (TimeCap != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TimeCap);
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
      if (other.Type != 0) {
        Type = other.Type;
      }
      exercises_.Add(other.exercises_);
      if (other.TimeCap != 0) {
        TimeCap = other.TimeCap;
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
          case 16: {
            type_ = (global::training.TrainingType) input.ReadEnum();
            break;
          }
          case 26: {
            exercises_.AddEntriesFrom(input, _repeated_exercises_codec);
            break;
          }
          case 32: {
            TimeCap = input.ReadInt32();
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
      get { return global::training.TrainingReflection.Descriptor.MessageTypes[2]; }
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
