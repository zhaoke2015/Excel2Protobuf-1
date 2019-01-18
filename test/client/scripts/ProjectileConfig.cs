// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Projectile_Config.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ConfigData {

  /// <summary>Holder for reflection information generated from Projectile_Config.proto</summary>
  public static partial class ProjectileConfigReflection {

    #region Descriptor
    /// <summary>File descriptor for Projectile_Config.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProjectileConfigReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdQcm9qZWN0aWxlX0NvbmZpZy5wcm90bxIKQ29uZmlnRGF0YSKpAQoRUHJv",
            "amVjdGlsZV9Db25maWcSCgoCaWQYASABKA0SEAoIZ3VuX2ZpcmUYAiABKAkS",
            "DgoGZWZmZWN0GAMgASgJEhIKCmhpdF9lZmZlY3QYBCABKAkSDQoFc3BlZWQY",
            "BSABKAISEgoKaGVpZ2h0X21pbhgGIAEoAhISCgpoZWlnaHRfbWF4GAcgASgC",
            "EhsKE2JhbGxpc3RpY19jYWxjX3JhdGUYCCABKAIi1QEKFlByb2plY3RpbGVf",
            "Q29uZmlnX0RhdGESXgoXUHJvamVjdGlsZV9Db25maWdfaXRlbXMYASADKAsy",
            "PS5Db25maWdEYXRhLlByb2plY3RpbGVfQ29uZmlnX0RhdGEuUHJvamVjdGls",
            "ZUNvbmZpZ0l0ZW1zRW50cnkaWwoaUHJvamVjdGlsZUNvbmZpZ0l0ZW1zRW50",
            "cnkSCwoDa2V5GAEgASgNEiwKBXZhbHVlGAIgASgLMh0uQ29uZmlnRGF0YS5Q",
            "cm9qZWN0aWxlX0NvbmZpZzoCOAFCIwohY29tLnRyaW5pdGlnYW1lcy5zZXJ2",
            "ZXIuY29uZi5hdXRvYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ConfigData.Projectile_Config), global::ConfigData.Projectile_Config.Parser, new[]{ "Id", "GunFire", "Effect", "HitEffect", "Speed", "HeightMin", "HeightMax", "BallisticCalcRate" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ConfigData.Projectile_Config_Data), global::ConfigData.Projectile_Config_Data.Parser, new[]{ "ProjectileConfigItems" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Projectile_Config : pb::IMessage<Projectile_Config> {
    private static readonly pb::MessageParser<Projectile_Config> _parser = new pb::MessageParser<Projectile_Config>(() => new Projectile_Config());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Projectile_Config> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ConfigData.ProjectileConfigReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Projectile_Config() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Projectile_Config(Projectile_Config other) : this() {
      id_ = other.id_;
      gunFire_ = other.gunFire_;
      effect_ = other.effect_;
      hitEffect_ = other.hitEffect_;
      speed_ = other.speed_;
      heightMin_ = other.heightMin_;
      heightMax_ = other.heightMax_;
      ballisticCalcRate_ = other.ballisticCalcRate_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Projectile_Config Clone() {
      return new Projectile_Config(this);
    }

    /// <summary>Field number for the "id" field.</summary>
    public const int IdFieldNumber = 1;
    private uint id_;
    /// <summary>
    ///* 唯一标识 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public uint Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }

    /// <summary>Field number for the "gun_fire" field.</summary>
    public const int GunFireFieldNumber = 2;
    private string gunFire_ = "";
    /// <summary>
    ///* 枪火特效 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string GunFire {
      get { return gunFire_; }
      set {
        gunFire_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "effect" field.</summary>
    public const int EffectFieldNumber = 3;
    private string effect_ = "";
    /// <summary>
    ///* 飞行性机能特效名 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Effect {
      get { return effect_; }
      set {
        effect_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "hit_effect" field.</summary>
    public const int HitEffectFieldNumber = 4;
    private string hitEffect_ = "";
    /// <summary>
    ///* 击中特效 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string HitEffect {
      get { return hitEffect_; }
      set {
        hitEffect_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "speed" field.</summary>
    public const int SpeedFieldNumber = 5;
    private float speed_;
    /// <summary>
    ///* 飞行速度 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float Speed {
      get { return speed_; }
      set {
        speed_ = value;
      }
    }

    /// <summary>Field number for the "height_min" field.</summary>
    public const int HeightMinFieldNumber = 6;
    private float heightMin_;
    /// <summary>
    ///* 高度距离比 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float HeightMin {
      get { return heightMin_; }
      set {
        heightMin_ = value;
      }
    }

    /// <summary>Field number for the "height_max" field.</summary>
    public const int HeightMaxFieldNumber = 7;
    private float heightMax_;
    /// <summary>
    ///* 高度距离比 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float HeightMax {
      get { return heightMax_; }
      set {
        heightMax_ = value;
      }
    }

    /// <summary>Field number for the "ballistic_calc_rate" field.</summary>
    public const int BallisticCalcRateFieldNumber = 8;
    private float ballisticCalcRate_;
    /// <summary>
    ///* 导弹追踪计算精准度 
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public float BallisticCalcRate {
      get { return ballisticCalcRate_; }
      set {
        ballisticCalcRate_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Projectile_Config);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Projectile_Config other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (GunFire != other.GunFire) return false;
      if (Effect != other.Effect) return false;
      if (HitEffect != other.HitEffect) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Speed, other.Speed)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(HeightMin, other.HeightMin)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(HeightMax, other.HeightMax)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(BallisticCalcRate, other.BallisticCalcRate)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id != 0) hash ^= Id.GetHashCode();
      if (GunFire.Length != 0) hash ^= GunFire.GetHashCode();
      if (Effect.Length != 0) hash ^= Effect.GetHashCode();
      if (HitEffect.Length != 0) hash ^= HitEffect.GetHashCode();
      if (Speed != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Speed);
      if (HeightMin != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(HeightMin);
      if (HeightMax != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(HeightMax);
      if (BallisticCalcRate != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(BallisticCalcRate);
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
      if (Id != 0) {
        output.WriteRawTag(8);
        output.WriteUInt32(Id);
      }
      if (GunFire.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(GunFire);
      }
      if (Effect.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Effect);
      }
      if (HitEffect.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(HitEffect);
      }
      if (Speed != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(Speed);
      }
      if (HeightMin != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(HeightMin);
      }
      if (HeightMax != 0F) {
        output.WriteRawTag(61);
        output.WriteFloat(HeightMax);
      }
      if (BallisticCalcRate != 0F) {
        output.WriteRawTag(69);
        output.WriteFloat(BallisticCalcRate);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id != 0) {
        size += 1 + pb::CodedOutputStream.ComputeUInt32Size(Id);
      }
      if (GunFire.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(GunFire);
      }
      if (Effect.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Effect);
      }
      if (HitEffect.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(HitEffect);
      }
      if (Speed != 0F) {
        size += 1 + 4;
      }
      if (HeightMin != 0F) {
        size += 1 + 4;
      }
      if (HeightMax != 0F) {
        size += 1 + 4;
      }
      if (BallisticCalcRate != 0F) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Projectile_Config other) {
      if (other == null) {
        return;
      }
      if (other.Id != 0) {
        Id = other.Id;
      }
      if (other.GunFire.Length != 0) {
        GunFire = other.GunFire;
      }
      if (other.Effect.Length != 0) {
        Effect = other.Effect;
      }
      if (other.HitEffect.Length != 0) {
        HitEffect = other.HitEffect;
      }
      if (other.Speed != 0F) {
        Speed = other.Speed;
      }
      if (other.HeightMin != 0F) {
        HeightMin = other.HeightMin;
      }
      if (other.HeightMax != 0F) {
        HeightMax = other.HeightMax;
      }
      if (other.BallisticCalcRate != 0F) {
        BallisticCalcRate = other.BallisticCalcRate;
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
            Id = input.ReadUInt32();
            break;
          }
          case 18: {
            GunFire = input.ReadString();
            break;
          }
          case 26: {
            Effect = input.ReadString();
            break;
          }
          case 34: {
            HitEffect = input.ReadString();
            break;
          }
          case 45: {
            Speed = input.ReadFloat();
            break;
          }
          case 53: {
            HeightMin = input.ReadFloat();
            break;
          }
          case 61: {
            HeightMax = input.ReadFloat();
            break;
          }
          case 69: {
            BallisticCalcRate = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Projectile_Config_Data : pb::IMessage<Projectile_Config_Data> {
    private static readonly pb::MessageParser<Projectile_Config_Data> _parser = new pb::MessageParser<Projectile_Config_Data>(() => new Projectile_Config_Data());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Projectile_Config_Data> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ConfigData.ProjectileConfigReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Projectile_Config_Data() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Projectile_Config_Data(Projectile_Config_Data other) : this() {
      projectileConfigItems_ = other.projectileConfigItems_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Projectile_Config_Data Clone() {
      return new Projectile_Config_Data(this);
    }

    /// <summary>Field number for the "Projectile_Config_items" field.</summary>
    public const int ProjectileConfigItemsFieldNumber = 1;
    private static readonly pbc::MapField<uint, global::ConfigData.Projectile_Config>.Codec _map_projectileConfigItems_codec
        = new pbc::MapField<uint, global::ConfigData.Projectile_Config>.Codec(pb::FieldCodec.ForUInt32(8), pb::FieldCodec.ForMessage(18, global::ConfigData.Projectile_Config.Parser), 10);
    private readonly pbc::MapField<uint, global::ConfigData.Projectile_Config> projectileConfigItems_ = new pbc::MapField<uint, global::ConfigData.Projectile_Config>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<uint, global::ConfigData.Projectile_Config> ProjectileConfigItems {
      get { return projectileConfigItems_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Projectile_Config_Data);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Projectile_Config_Data other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!ProjectileConfigItems.Equals(other.ProjectileConfigItems)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= ProjectileConfigItems.GetHashCode();
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
      projectileConfigItems_.WriteTo(output, _map_projectileConfigItems_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += projectileConfigItems_.CalculateSize(_map_projectileConfigItems_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Projectile_Config_Data other) {
      if (other == null) {
        return;
      }
      projectileConfigItems_.Add(other.projectileConfigItems_);
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
            projectileConfigItems_.AddEntriesFrom(input, _map_projectileConfigItems_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code