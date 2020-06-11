// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/errors/date_range_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/errors/date_range_error.proto</summary>
  public static partial class DateRangeErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/errors/date_range_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DateRangeErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lcnJvcnMvZGF0ZV9yYW5nZV9l",
            "cnJvci5wcm90bxIeZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEuZXJyb3JzGhxn",
            "b29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvIuYBChJEYXRlUmFuZ2VFcnJv",
            "ckVudW0izwEKDkRhdGVSYW5nZUVycm9yEg8KC1VOU1BFQ0lGSUVEEAASCwoH",
            "VU5LTk9XThABEhAKDElOVkFMSURfREFURRACEh0KGVNUQVJUX0RBVEVfQUZU",
            "RVJfRU5EX0RBVEUQAxIbChdDQU5OT1RfU0VUX0RBVEVfVE9fUEFTVBAEEiAK",
            "HEFGVEVSX01BWElNVU1fQUxMT1dBQkxFX0RBVEUQBRIvCitDQU5OT1RfTU9E",
            "SUZZX1NUQVJUX0RBVEVfSUZfQUxSRUFEWV9TVEFSVEVEEAZC7gEKImNvbS5n",
            "b29nbGUuYWRzLmdvb2dsZWFkcy52MS5lcnJvcnNCE0RhdGVSYW5nZUVycm9y",
            "UHJvdG9QAVpEZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBp",
            "cy9hZHMvZ29vZ2xlYWRzL3YxL2Vycm9ycztlcnJvcnOiAgNHQUGqAh5Hb29n",
            "bGUuQWRzLkdvb2dsZUFkcy5WMS5FcnJvcnPKAh5Hb29nbGVcQWRzXEdvb2ds",
            "ZUFkc1xWMVxFcnJvcnPqAiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTo6",
            "RXJyb3JzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Errors.DateRangeErrorEnum), global::Google.Ads.GoogleAds.V1.Errors.DateRangeErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Errors.DateRangeErrorEnum.Types.DateRangeError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible date range errors.
  /// </summary>
  public sealed partial class DateRangeErrorEnum : pb::IMessage<DateRangeErrorEnum> {
    private static readonly pb::MessageParser<DateRangeErrorEnum> _parser = new pb::MessageParser<DateRangeErrorEnum>(() => new DateRangeErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<DateRangeErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Errors.DateRangeErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DateRangeErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DateRangeErrorEnum(DateRangeErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public DateRangeErrorEnum Clone() {
      return new DateRangeErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as DateRangeErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(DateRangeErrorEnum other) {
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
    public void MergeFrom(DateRangeErrorEnum other) {
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
    /// <summary>Container for nested types declared in the DateRangeErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing possible date range errors.
      /// </summary>
      public enum DateRangeError {
        /// <summary>
        /// Enum unspecified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received error code is not known in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Invalid date.
        /// </summary>
        [pbr::OriginalName("INVALID_DATE")] InvalidDate = 2,
        /// <summary>
        /// The start date was after the end date.
        /// </summary>
        [pbr::OriginalName("START_DATE_AFTER_END_DATE")] StartDateAfterEndDate = 3,
        /// <summary>
        /// Cannot set date to past time
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_DATE_TO_PAST")] CannotSetDateToPast = 4,
        /// <summary>
        /// A date was used that is past the system "last" date.
        /// </summary>
        [pbr::OriginalName("AFTER_MAXIMUM_ALLOWABLE_DATE")] AfterMaximumAllowableDate = 5,
        /// <summary>
        /// Trying to change start date on a resource that has started.
        /// </summary>
        [pbr::OriginalName("CANNOT_MODIFY_START_DATE_IF_ALREADY_STARTED")] CannotModifyStartDateIfAlreadyStarted = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
