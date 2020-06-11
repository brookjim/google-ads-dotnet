// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/errors/asset_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/errors/asset_error.proto</summary>
  public static partial class AssetErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/errors/asset_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lcnJvcnMvYXNzZXRfZXJyb3Iu",
            "cHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxLmVycm9ycxocZ29vZ2xl",
            "L2FwaS9hbm5vdGF0aW9ucy5wcm90byLSAQoOQXNzZXRFcnJvckVudW0ivwEK",
            "CkFzc2V0RXJyb3ISDwoLVU5TUEVDSUZJRUQQABILCgdVTktOT1dOEAESKwon",
            "Q1VTVE9NRVJfTk9UX1dISVRFTElTVEVEX0ZPUl9BU1NFVF9UWVBFEAISEwoP",
            "RFVQTElDQVRFX0FTU0VUEAMSGAoURFVQTElDQVRFX0FTU0VUX05BTUUQBBIZ",
            "ChVBU1NFVF9EQVRBX0lTX01JU1NJTkcQBRIcChhDQU5OT1RfTU9ESUZZX0FT",
            "U0VUX05BTUUQBkLqAQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxLmVy",
            "cm9yc0IPQXNzZXRFcnJvclByb3RvUAFaRGdvb2dsZS5nb2xhbmcub3JnL2dl",
            "bnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MS9lcnJvcnM7ZXJy",
            "b3JzogIDR0FBqgIeR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjEuRXJyb3JzygIe",
            "R29vZ2xlXEFkc1xHb29nbGVBZHNcVjFcRXJyb3Jz6gIiR29vZ2xlOjpBZHM6",
            "Okdvb2dsZUFkczo6VjE6OkVycm9yc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Errors.AssetErrorEnum), global::Google.Ads.GoogleAds.V1.Errors.AssetErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Errors.AssetErrorEnum.Types.AssetError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible asset errors.
  /// </summary>
  public sealed partial class AssetErrorEnum : pb::IMessage<AssetErrorEnum> {
    private static readonly pb::MessageParser<AssetErrorEnum> _parser = new pb::MessageParser<AssetErrorEnum>(() => new AssetErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AssetErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Errors.AssetErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AssetErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AssetErrorEnum(AssetErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AssetErrorEnum Clone() {
      return new AssetErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AssetErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AssetErrorEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
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
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AssetErrorEnum other) {
      if (other == null) {
        return;
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
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the AssetErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible asset errors.
      /// </summary>
      public enum AssetError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The customer is not whitelisted for this asset type.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_NOT_WHITELISTED_FOR_ASSET_TYPE")] CustomerNotWhitelistedForAssetType = 2,
        /// <summary>
        /// Assets are duplicated across operations.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_ASSET")] DuplicateAsset = 3,
        /// <summary>
        /// The asset name is duplicated, either across operations or with an
        /// existing asset.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_ASSET_NAME")] DuplicateAssetName = 4,
        /// <summary>
        /// The Asset.asset_data oneof is empty.
        /// </summary>
        [pbr::OriginalName("ASSET_DATA_IS_MISSING")] AssetDataIsMissing = 5,
        /// <summary>
        /// The asset has a name which is different from an existing duplicate that
        /// represents the same content.
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_ASSET_NAME")] CannotModifyAssetName = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
