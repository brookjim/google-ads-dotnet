// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v1/errors/feed_item_validation_error.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V1.Errors {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v1/errors/feed_item_validation_error.proto</summary>
  public static partial class FeedItemValidationErrorReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v1/errors/feed_item_validation_error.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeedItemValidationErrorReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj9nb29nbGUvYWRzL2dvb2dsZWFkcy92MS9lcnJvcnMvZmVlZF9pdGVtX3Zh",
            "bGlkYXRpb25fZXJyb3IucHJvdG8SHmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYx",
            "LmVycm9ycxocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byK0GQobRmVl",
            "ZEl0ZW1WYWxpZGF0aW9uRXJyb3JFbnVtIpQZChdGZWVkSXRlbVZhbGlkYXRp",
            "b25FcnJvchIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIUChBTVFJJ",
            "TkdfVE9PX1NIT1JUEAISEwoPU1RSSU5HX1RPT19MT05HEAMSFwoTVkFMVUVf",
            "Tk9UX1NQRUNJRklFRBAEEigKJElOVkFMSURfRE9NRVNUSUNfUEhPTkVfTlVN",
            "QkVSX0ZPUk1BVBAFEhgKFElOVkFMSURfUEhPTkVfTlVNQkVSEAYSKgomUEhP",
            "TkVfTlVNQkVSX05PVF9TVVBQT1JURURfRk9SX0NPVU5UUlkQBxIjCh9QUkVN",
            "SVVNX1JBVEVfTlVNQkVSX05PVF9BTExPV0VEEAgSGgoWRElTQUxMT1dFRF9O",
            "VU1CRVJfVFlQRRAJEhYKElZBTFVFX09VVF9PRl9SQU5HRRAKEioKJkNBTExU",
            "UkFDS0lOR19OT1RfU1VQUE9SVEVEX0ZPUl9DT1VOVFJZEAsSLQopQ1VTVE9N",
            "RVJfTk9UX1dISVRFTElTVEVEX0ZPUl9DQUxMVFJBQ0tJTkcQDBIYChRJTlZB",
            "TElEX0NPVU5UUllfQ09ERRANEhIKDklOVkFMSURfQVBQX0lEEA4SIQodTUlT",
            "U0lOR19BVFRSSUJVVEVTX0ZPUl9GSUVMRFMQDxITCg9JTlZBTElEX1RZUEVf",
            "SUQQEBIZChVJTlZBTElEX0VNQUlMX0FERFJFU1MQERIVChFJTlZBTElEX0hU",
            "VFBTX1VSTBASEhwKGE1JU1NJTkdfREVMSVZFUllfQUREUkVTUxATEh0KGVNU",
            "QVJUX0RBVEVfQUZURVJfRU5EX0RBVEUQFBIgChxNSVNTSU5HX0ZFRURfSVRF",
            "TV9TVEFSVF9USU1FEBUSHgoaTUlTU0lOR19GRUVEX0lURU1fRU5EX1RJTUUQ",
            "FhIYChRNSVNTSU5HX0ZFRURfSVRFTV9JRBAXEiMKH1ZBTklUWV9QSE9ORV9O",
            "VU1CRVJfTk9UX0FMTE9XRUQQGBIkCiBJTlZBTElEX1JFVklFV19FWFRFTlNJ",
            "T05fU05JUFBFVBAZEhkKFUlOVkFMSURfTlVNQkVSX0ZPUk1BVBAaEhcKE0lO",
            "VkFMSURfREFURV9GT1JNQVQQGxIYChRJTlZBTElEX1BSSUNFX0ZPUk1BVBAc",
            "Eh0KGVVOS05PV05fUExBQ0VIT0xERVJfRklFTEQQHRIuCipNSVNTSU5HX0VO",
            "SEFOQ0VEX1NJVEVMSU5LX0RFU0NSSVBUSU9OX0xJTkUQHhImCiJSRVZJRVdf",
            "RVhURU5TSU9OX1NPVVJDRV9JTkVMSUdJQkxFEB8SJwojSFlQSEVOU19JTl9S",
            "RVZJRVdfRVhURU5TSU9OX1NOSVBQRVQQIBItCilET1VCTEVfUVVPVEVTX0lO",
            "X1JFVklFV19FWFRFTlNJT05fU05JUFBFVBAhEiYKIlFVT1RFU19JTl9SRVZJ",
            "RVdfRVhURU5TSU9OX1NOSVBQRVQQIhIfChtJTlZBTElEX0ZPUk1fRU5DT0RF",
            "RF9QQVJBTVMQIxIeChpJTlZBTElEX1VSTF9QQVJBTUVURVJfTkFNRRAkEhcK",
            "E05PX0dFT0NPRElOR19SRVNVTFQQJRIoCiRTT1VSQ0VfTkFNRV9JTl9SRVZJ",
            "RVdfRVhURU5TSU9OX1RFWFQQJhItCilDQVJSSUVSX1NQRUNJRklDX1NIT1JU",
            "X05VTUJFUl9OT1RfQUxMT1dFRBAnEiAKHElOVkFMSURfUExBQ0VIT0xERVJf",
            "RklFTERfSUQQKBITCg9JTlZBTElEX1VSTF9UQUcQKRIRCg1MSVNUX1RPT19M",
            "T05HECoSIgoeSU5WQUxJRF9BVFRSSUJVVEVTX0NPTUJJTkFUSU9OECsSFAoQ",
            "RFVQTElDQVRFX1ZBTFVFUxAsEiUKIUlOVkFMSURfQ0FMTF9DT05WRVJTSU9O",
            "X0FDVElPTl9JRBAtEiEKHUNBTk5PVF9TRVRfV0lUSE9VVF9GSU5BTF9VUkxT",
            "EC4SJAogQVBQX0lEX0RPRVNOVF9FWElTVF9JTl9BUFBfU1RPUkUQLxIVChFJ",
            "TlZBTElEX0ZJTkFMX1VSTBAwEhgKFElOVkFMSURfVFJBQ0tJTkdfVVJMEDES",
            "KgomSU5WQUxJRF9GSU5BTF9VUkxfRk9SX0FQUF9ET1dOTE9BRF9VUkwQMhIS",
            "Cg5MSVNUX1RPT19TSE9SVBAzEhcKE0lOVkFMSURfVVNFUl9BQ1RJT04QNBIV",
            "ChFJTlZBTElEX1RZUEVfTkFNRRA1Eh8KG0lOVkFMSURfRVZFTlRfQ0hBTkdF",
            "X1NUQVRVUxA2EhsKF0lOVkFMSURfU05JUFBFVFNfSEVBREVSEDcSHAoYSU5W",
            "QUxJRF9BTkRST0lEX0FQUF9MSU5LEDgSOwo3TlVNQkVSX1RZUEVfV0lUSF9D",
            "QUxMVFJBQ0tJTkdfTk9UX1NVUFBPUlRFRF9GT1JfQ09VTlRSWRA5EhoKFlJF",
            "U0VSVkVEX0tFWVdPUkRfT1RIRVIQOhIbChdEVVBMSUNBVEVfT1BUSU9OX0xB",
            "QkVMUxA7Eh0KGURVUExJQ0FURV9PUFRJT05fUFJFRklMTFMQPBIYChRVTkVR",
            "VUFMX0xJU1RfTEVOR1RIUxA9Eh8KG0lOQ09OU0lTVEVOVF9DVVJSRU5DWV9D",
            "T0RFUxA+EioKJlBSSUNFX0VYVEVOU0lPTl9IQVNfRFVQTElDQVRFRF9IRUFE",
            "RVJTED8SLgoqSVRFTV9IQVNfRFVQTElDQVRFRF9IRUFERVJfQU5EX0RFU0NS",
            "SVBUSU9OEEASJQohUFJJQ0VfRVhURU5TSU9OX0hBU19UT09fRkVXX0lURU1T",
            "EEESFQoRVU5TVVBQT1JURURfVkFMVUUQQhIcChhJTlZBTElEX0ZJTkFMX01P",
            "QklMRV9VUkwQQxIlCiFJTlZBTElEX0tFWVdPUkRMRVNTX0FEX1JVTEVfTEFC",
            "RUwQRBInCiNWQUxVRV9UUkFDS19QQVJBTUVURVJfTk9UX1NVUFBPUlRFRBBF",
            "EioKJlVOU1VQUE9SVEVEX1ZBTFVFX0lOX1NFTEVDVEVEX0xBTkdVQUdFEEYS",
            "GAoUSU5WQUxJRF9JT1NfQVBQX0xJTksQRxIsCihNSVNTSU5HX0lPU19BUFBf",
            "TElOS19PUl9JT1NfQVBQX1NUT1JFX0lEEEgSGgoWUFJPTU9USU9OX0lOVkFM",
            "SURfVElNRRBJEjkKNVBST01PVElPTl9DQU5OT1RfU0VUX1BFUkNFTlRfT0ZG",
            "X0FORF9NT05FWV9BTU9VTlRfT0ZGEEoSPgo6UFJPTU9USU9OX0NBTk5PVF9T",
            "RVRfUFJPTU9USU9OX0NPREVfQU5EX09SREVSU19PVkVSX0FNT1VOVBBLEiUK",
            "IVRPT19NQU5ZX0RFQ0lNQUxfUExBQ0VTX1NQRUNJRklFRBBMEh4KGkFEX0NV",
            "U1RPTUlaRVJTX05PVF9BTExPV0VEEE0SGQoVSU5WQUxJRF9MQU5HVUFHRV9D",
            "T0RFEE4SGAoUVU5TVVBQT1JURURfTEFOR1VBR0UQTxIbChdJRl9GVU5DVElP",
            "Tl9OT1RfQUxMT1dFRBBQEhwKGElOVkFMSURfRklOQUxfVVJMX1NVRkZJWBBR",
            "EiMKH0lOVkFMSURfVEFHX0lOX0ZJTkFMX1VSTF9TVUZGSVgQUhIjCh9JTlZB",
            "TElEX0ZJTkFMX1VSTF9TVUZGSVhfRk9STUFUEFMSMAosQ1VTVE9NRVJfQ09O",
            "U0VOVF9GT1JfQ0FMTF9SRUNPUkRJTkdfUkVRVUlSRUQQVBInCiNPTkxZX09O",
            "RV9ERUxJVkVSWV9PUFRJT05fSVNfQUxMT1dFRBBVEh0KGU5PX0RFTElWRVJZ",
            "X09QVElPTl9JU19TRVQQVhImCiJJTlZBTElEX0NPTlZFUlNJT05fUkVQT1JU",
            "SU5HX1NUQVRFEFcSFAoQSU1BR0VfU0laRV9XUk9ORxBYEisKJ0VNQUlMX0RF",
            "TElWRVJZX05PVF9BVkFJTEFCTEVfSU5fQ09VTlRSWRBZEicKI0FVVE9fUkVQ",
            "TFlfTk9UX0FWQUlMQUJMRV9JTl9DT1VOVFJZEFoSGgoWSU5WQUxJRF9MQVRJ",
            "VFVERV9WQUxVRRBbEhsKF0lOVkFMSURfTE9OR0lUVURFX1ZBTFVFEFwSEwoP",
            "VE9PX01BTllfTEFCRUxTEF0SFQoRSU5WQUxJRF9JTUFHRV9VUkwQXhIaChZN",
            "SVNTSU5HX0xBVElUVURFX1ZBTFVFEF8SGwoXTUlTU0lOR19MT05HSVRVREVf",
            "VkFMVUUQYEL3AQoiY29tLmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYxLmVycm9y",
            "c0IcRmVlZEl0ZW1WYWxpZGF0aW9uRXJyb3JQcm90b1ABWkRnb29nbGUuZ29s",
            "YW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjEv",
            "ZXJyb3JzO2Vycm9yc6ICA0dBQaoCHkdvb2dsZS5BZHMuR29vZ2xlQWRzLlYx",
            "LkVycm9yc8oCHkdvb2dsZVxBZHNcR29vZ2xlQWRzXFYxXEVycm9yc+oCIkdv",
            "b2dsZTo6QWRzOjpHb29nbGVBZHM6OlYxOjpFcnJvcnNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V1.Errors.FeedItemValidationErrorEnum), global::Google.Ads.GoogleAds.V1.Errors.FeedItemValidationErrorEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V1.Errors.FeedItemValidationErrorEnum.Types.FeedItemValidationError) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible validation errors of a feed item.
  /// </summary>
  public sealed partial class FeedItemValidationErrorEnum : pb::IMessage<FeedItemValidationErrorEnum> {
    private static readonly pb::MessageParser<FeedItemValidationErrorEnum> _parser = new pb::MessageParser<FeedItemValidationErrorEnum>(() => new FeedItemValidationErrorEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FeedItemValidationErrorEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V1.Errors.FeedItemValidationErrorReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedItemValidationErrorEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedItemValidationErrorEnum(FeedItemValidationErrorEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedItemValidationErrorEnum Clone() {
      return new FeedItemValidationErrorEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FeedItemValidationErrorEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FeedItemValidationErrorEnum other) {
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
    public void MergeFrom(FeedItemValidationErrorEnum other) {
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
    /// <summary>Container for nested types declared in the FeedItemValidationErrorEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// The possible validation errors of a feed item.
      /// </summary>
      public enum FeedItemValidationError {
        /// <summary>
        /// No value has been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// String is too short.
        /// </summary>
        [pbr::OriginalName("STRING_TOO_SHORT")] StringTooShort = 2,
        /// <summary>
        /// String is too long.
        /// </summary>
        [pbr::OriginalName("STRING_TOO_LONG")] StringTooLong = 3,
        /// <summary>
        /// Value is not provided.
        /// </summary>
        [pbr::OriginalName("VALUE_NOT_SPECIFIED")] ValueNotSpecified = 4,
        /// <summary>
        /// Phone number format is invalid for region.
        /// </summary>
        [pbr::OriginalName("INVALID_DOMESTIC_PHONE_NUMBER_FORMAT")] InvalidDomesticPhoneNumberFormat = 5,
        /// <summary>
        /// String does not represent a phone number.
        /// </summary>
        [pbr::OriginalName("INVALID_PHONE_NUMBER")] InvalidPhoneNumber = 6,
        /// <summary>
        /// Phone number format is not compatible with country code.
        /// </summary>
        [pbr::OriginalName("PHONE_NUMBER_NOT_SUPPORTED_FOR_COUNTRY")] PhoneNumberNotSupportedForCountry = 7,
        /// <summary>
        /// Premium rate number is not allowed.
        /// </summary>
        [pbr::OriginalName("PREMIUM_RATE_NUMBER_NOT_ALLOWED")] PremiumRateNumberNotAllowed = 8,
        /// <summary>
        /// Phone number type is not allowed.
        /// </summary>
        [pbr::OriginalName("DISALLOWED_NUMBER_TYPE")] DisallowedNumberType = 9,
        /// <summary>
        /// Specified value is outside of the valid range.
        /// </summary>
        [pbr::OriginalName("VALUE_OUT_OF_RANGE")] ValueOutOfRange = 10,
        /// <summary>
        /// Call tracking is not supported in the selected country.
        /// </summary>
        [pbr::OriginalName("CALLTRACKING_NOT_SUPPORTED_FOR_COUNTRY")] CalltrackingNotSupportedForCountry = 11,
        /// <summary>
        /// Customer is not whitelisted for call tracking.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_NOT_WHITELISTED_FOR_CALLTRACKING")] CustomerNotWhitelistedForCalltracking = 12,
        /// <summary>
        /// Country code is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_COUNTRY_CODE")] InvalidCountryCode = 13,
        /// <summary>
        /// The specified mobile app id is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_APP_ID")] InvalidAppId = 14,
        /// <summary>
        /// Some required field attributes are missing.
        /// </summary>
        [pbr::OriginalName("MISSING_ATTRIBUTES_FOR_FIELDS")] MissingAttributesForFields = 15,
        /// <summary>
        /// Invalid email button type for email extension.
        /// </summary>
        [pbr::OriginalName("INVALID_TYPE_ID")] InvalidTypeId = 16,
        /// <summary>
        /// Email address is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_EMAIL_ADDRESS")] InvalidEmailAddress = 17,
        /// <summary>
        /// The HTTPS URL in email extension is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_HTTPS_URL")] InvalidHttpsUrl = 18,
        /// <summary>
        /// Delivery address is missing from email extension.
        /// </summary>
        [pbr::OriginalName("MISSING_DELIVERY_ADDRESS")] MissingDeliveryAddress = 19,
        /// <summary>
        /// FeedItem scheduling start date comes after end date.
        /// </summary>
        [pbr::OriginalName("START_DATE_AFTER_END_DATE")] StartDateAfterEndDate = 20,
        /// <summary>
        /// FeedItem scheduling start time is missing.
        /// </summary>
        [pbr::OriginalName("MISSING_FEED_ITEM_START_TIME")] MissingFeedItemStartTime = 21,
        /// <summary>
        /// FeedItem scheduling end time is missing.
        /// </summary>
        [pbr::OriginalName("MISSING_FEED_ITEM_END_TIME")] MissingFeedItemEndTime = 22,
        /// <summary>
        /// Cannot compute system attributes on a FeedItem that has no FeedItemId.
        /// </summary>
        [pbr::OriginalName("MISSING_FEED_ITEM_ID")] MissingFeedItemId = 23,
        /// <summary>
        /// Call extension vanity phone numbers are not supported.
        /// </summary>
        [pbr::OriginalName("VANITY_PHONE_NUMBER_NOT_ALLOWED")] VanityPhoneNumberNotAllowed = 24,
        /// <summary>
        /// Invalid review text.
        /// </summary>
        [pbr::OriginalName("INVALID_REVIEW_EXTENSION_SNIPPET")] InvalidReviewExtensionSnippet = 25,
        /// <summary>
        /// Invalid format for numeric value in ad parameter.
        /// </summary>
        [pbr::OriginalName("INVALID_NUMBER_FORMAT")] InvalidNumberFormat = 26,
        /// <summary>
        /// Invalid format for date value in ad parameter.
        /// </summary>
        [pbr::OriginalName("INVALID_DATE_FORMAT")] InvalidDateFormat = 27,
        /// <summary>
        /// Invalid format for price value in ad parameter.
        /// </summary>
        [pbr::OriginalName("INVALID_PRICE_FORMAT")] InvalidPriceFormat = 28,
        /// <summary>
        /// Unrecognized type given for value in ad parameter.
        /// </summary>
        [pbr::OriginalName("UNKNOWN_PLACEHOLDER_FIELD")] UnknownPlaceholderField = 29,
        /// <summary>
        /// Enhanced sitelinks must have both description lines specified.
        /// </summary>
        [pbr::OriginalName("MISSING_ENHANCED_SITELINK_DESCRIPTION_LINE")] MissingEnhancedSitelinkDescriptionLine = 30,
        /// <summary>
        /// Review source is ineligible.
        /// </summary>
        [pbr::OriginalName("REVIEW_EXTENSION_SOURCE_INELIGIBLE")] ReviewExtensionSourceIneligible = 31,
        /// <summary>
        /// Review text cannot contain hyphens or dashes.
        /// </summary>
        [pbr::OriginalName("HYPHENS_IN_REVIEW_EXTENSION_SNIPPET")] HyphensInReviewExtensionSnippet = 32,
        /// <summary>
        /// Review text cannot contain double quote characters.
        /// </summary>
        [pbr::OriginalName("DOUBLE_QUOTES_IN_REVIEW_EXTENSION_SNIPPET")] DoubleQuotesInReviewExtensionSnippet = 33,
        /// <summary>
        /// Review text cannot contain quote characters.
        /// </summary>
        [pbr::OriginalName("QUOTES_IN_REVIEW_EXTENSION_SNIPPET")] QuotesInReviewExtensionSnippet = 34,
        /// <summary>
        /// Parameters are encoded in the wrong format.
        /// </summary>
        [pbr::OriginalName("INVALID_FORM_ENCODED_PARAMS")] InvalidFormEncodedParams = 35,
        /// <summary>
        /// URL parameter name must contain only letters, numbers, underscores, and
        /// dashes.
        /// </summary>
        [pbr::OriginalName("INVALID_URL_PARAMETER_NAME")] InvalidUrlParameterName = 36,
        /// <summary>
        /// Cannot find address location.
        /// </summary>
        [pbr::OriginalName("NO_GEOCODING_RESULT")] NoGeocodingResult = 37,
        /// <summary>
        /// Review extension text has source name.
        /// </summary>
        [pbr::OriginalName("SOURCE_NAME_IN_REVIEW_EXTENSION_TEXT")] SourceNameInReviewExtensionText = 38,
        /// <summary>
        /// Some phone numbers can be shorter than usual. Some of these short numbers
        /// are carrier-specific, and we disallow those in ad extensions because they
        /// will not be available to all users.
        /// </summary>
        [pbr::OriginalName("CARRIER_SPECIFIC_SHORT_NUMBER_NOT_ALLOWED")] CarrierSpecificShortNumberNotAllowed = 39,
        /// <summary>
        /// Triggered when a request references a placeholder field id that does not
        /// exist.
        /// </summary>
        [pbr::OriginalName("INVALID_PLACEHOLDER_FIELD_ID")] InvalidPlaceholderFieldId = 40,
        /// <summary>
        /// URL contains invalid ValueTrack tags or format.
        /// </summary>
        [pbr::OriginalName("INVALID_URL_TAG")] InvalidUrlTag = 41,
        /// <summary>
        /// Provided list exceeds acceptable size.
        /// </summary>
        [pbr::OriginalName("LIST_TOO_LONG")] ListTooLong = 42,
        /// <summary>
        /// Certain combinations of attributes aren't allowed to be specified in the
        /// same feed item.
        /// </summary>
        [pbr::OriginalName("INVALID_ATTRIBUTES_COMBINATION")] InvalidAttributesCombination = 43,
        /// <summary>
        /// An attribute has the same value repeatedly.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_VALUES")] DuplicateValues = 44,
        /// <summary>
        /// Advertisers can link a conversion action with a phone number to indicate
        /// that sufficiently long calls forwarded to that phone number should be
        /// counted as conversions of the specified type.  This is an error message
        /// indicating that the conversion action specified is invalid (e.g., the
        /// conversion action does not exist within the appropriate Google Ads
        /// account, or it is a type of conversion not appropriate to phone call
        /// conversions).
        /// </summary>
        [pbr::OriginalName("INVALID_CALL_CONVERSION_ACTION_ID")] InvalidCallConversionActionId = 45,
        /// <summary>
        /// Tracking template requires final url to be set.
        /// </summary>
        [pbr::OriginalName("CANNOT_SET_WITHOUT_FINAL_URLS")] CannotSetWithoutFinalUrls = 46,
        /// <summary>
        /// An app id was provided that doesn't exist in the given app store.
        /// </summary>
        [pbr::OriginalName("APP_ID_DOESNT_EXIST_IN_APP_STORE")] AppIdDoesntExistInAppStore = 47,
        /// <summary>
        /// Invalid U2 final url.
        /// </summary>
        [pbr::OriginalName("INVALID_FINAL_URL")] InvalidFinalUrl = 48,
        /// <summary>
        /// Invalid U2 tracking url.
        /// </summary>
        [pbr::OriginalName("INVALID_TRACKING_URL")] InvalidTrackingUrl = 49,
        /// <summary>
        /// Final URL should start from App download URL.
        /// </summary>
        [pbr::OriginalName("INVALID_FINAL_URL_FOR_APP_DOWNLOAD_URL")] InvalidFinalUrlForAppDownloadUrl = 50,
        /// <summary>
        /// List provided is too short.
        /// </summary>
        [pbr::OriginalName("LIST_TOO_SHORT")] ListTooShort = 51,
        /// <summary>
        /// User Action field has invalid value.
        /// </summary>
        [pbr::OriginalName("INVALID_USER_ACTION")] InvalidUserAction = 52,
        /// <summary>
        /// Type field has invalid value.
        /// </summary>
        [pbr::OriginalName("INVALID_TYPE_NAME")] InvalidTypeName = 53,
        /// <summary>
        /// Change status for event is invalid.
        /// </summary>
        [pbr::OriginalName("INVALID_EVENT_CHANGE_STATUS")] InvalidEventChangeStatus = 54,
        /// <summary>
        /// The header of a structured snippets extension is not one of the valid
        /// headers.
        /// </summary>
        [pbr::OriginalName("INVALID_SNIPPETS_HEADER")] InvalidSnippetsHeader = 55,
        /// <summary>
        /// Android app link is not formatted correctly
        /// </summary>
        [pbr::OriginalName("INVALID_ANDROID_APP_LINK")] InvalidAndroidAppLink = 56,
        /// <summary>
        /// Phone number incompatible with call tracking for country.
        /// </summary>
        [pbr::OriginalName("NUMBER_TYPE_WITH_CALLTRACKING_NOT_SUPPORTED_FOR_COUNTRY")] NumberTypeWithCalltrackingNotSupportedForCountry = 57,
        /// <summary>
        /// The input is identical to a reserved keyword
        /// </summary>
        [pbr::OriginalName("RESERVED_KEYWORD_OTHER")] ReservedKeywordOther = 58,
        /// <summary>
        /// Each option label in the message extension must be unique.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_OPTION_LABELS")] DuplicateOptionLabels = 59,
        /// <summary>
        /// Each option prefill in the message extension must be unique.
        /// </summary>
        [pbr::OriginalName("DUPLICATE_OPTION_PREFILLS")] DuplicateOptionPrefills = 60,
        /// <summary>
        /// In message extensions, the number of optional labels and optional
        /// prefills must be the same.
        /// </summary>
        [pbr::OriginalName("UNEQUAL_LIST_LENGTHS")] UnequalListLengths = 61,
        /// <summary>
        /// All currency codes in an ad extension must be the same.
        /// </summary>
        [pbr::OriginalName("INCONSISTENT_CURRENCY_CODES")] InconsistentCurrencyCodes = 62,
        /// <summary>
        /// Headers in price extension are not unique.
        /// </summary>
        [pbr::OriginalName("PRICE_EXTENSION_HAS_DUPLICATED_HEADERS")] PriceExtensionHasDuplicatedHeaders = 63,
        /// <summary>
        /// Header and description in an item are the same.
        /// </summary>
        [pbr::OriginalName("ITEM_HAS_DUPLICATED_HEADER_AND_DESCRIPTION")] ItemHasDuplicatedHeaderAndDescription = 64,
        /// <summary>
        /// Price extension has too few items.
        /// </summary>
        [pbr::OriginalName("PRICE_EXTENSION_HAS_TOO_FEW_ITEMS")] PriceExtensionHasTooFewItems = 65,
        /// <summary>
        /// The given value is not supported.
        /// </summary>
        [pbr::OriginalName("UNSUPPORTED_VALUE")] UnsupportedValue = 66,
        /// <summary>
        /// Invalid final mobile url.
        /// </summary>
        [pbr::OriginalName("INVALID_FINAL_MOBILE_URL")] InvalidFinalMobileUrl = 67,
        /// <summary>
        /// The given string value of Label contains invalid characters
        /// </summary>
        [pbr::OriginalName("INVALID_KEYWORDLESS_AD_RULE_LABEL")] InvalidKeywordlessAdRuleLabel = 68,
        /// <summary>
        /// The given URL contains value track parameters.
        /// </summary>
        [pbr::OriginalName("VALUE_TRACK_PARAMETER_NOT_SUPPORTED")] ValueTrackParameterNotSupported = 69,
        /// <summary>
        /// The given value is not supported in the selected language of an
        /// extension.
        /// </summary>
        [pbr::OriginalName("UNSUPPORTED_VALUE_IN_SELECTED_LANGUAGE")] UnsupportedValueInSelectedLanguage = 70,
        /// <summary>
        /// The iOS app link is not formatted correctly.
        /// </summary>
        [pbr::OriginalName("INVALID_IOS_APP_LINK")] InvalidIosAppLink = 71,
        /// <summary>
        /// iOS app link or iOS app store id is missing.
        /// </summary>
        [pbr::OriginalName("MISSING_IOS_APP_LINK_OR_IOS_APP_STORE_ID")] MissingIosAppLinkOrIosAppStoreId = 72,
        /// <summary>
        /// Promotion time is invalid.
        /// </summary>
        [pbr::OriginalName("PROMOTION_INVALID_TIME")] PromotionInvalidTime = 73,
        /// <summary>
        /// Both the percent off and money amount off fields are set.
        /// </summary>
        [pbr::OriginalName("PROMOTION_CANNOT_SET_PERCENT_OFF_AND_MONEY_AMOUNT_OFF")] PromotionCannotSetPercentOffAndMoneyAmountOff = 74,
        /// <summary>
        /// Both the promotion code and orders over amount fields are set.
        /// </summary>
        [pbr::OriginalName("PROMOTION_CANNOT_SET_PROMOTION_CODE_AND_ORDERS_OVER_AMOUNT")] PromotionCannotSetPromotionCodeAndOrdersOverAmount = 75,
        /// <summary>
        /// Too many decimal places are specified.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_DECIMAL_PLACES_SPECIFIED")] TooManyDecimalPlacesSpecified = 76,
        /// <summary>
        /// Ad Customizers are present and not allowed.
        /// </summary>
        [pbr::OriginalName("AD_CUSTOMIZERS_NOT_ALLOWED")] AdCustomizersNotAllowed = 77,
        /// <summary>
        /// Language code is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_LANGUAGE_CODE")] InvalidLanguageCode = 78,
        /// <summary>
        /// Language is not supported.
        /// </summary>
        [pbr::OriginalName("UNSUPPORTED_LANGUAGE")] UnsupportedLanguage = 79,
        /// <summary>
        /// IF Function is present and not allowed.
        /// </summary>
        [pbr::OriginalName("IF_FUNCTION_NOT_ALLOWED")] IfFunctionNotAllowed = 80,
        /// <summary>
        /// Final url suffix is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_FINAL_URL_SUFFIX")] InvalidFinalUrlSuffix = 81,
        /// <summary>
        /// Final url suffix contains an invalid tag.
        /// </summary>
        [pbr::OriginalName("INVALID_TAG_IN_FINAL_URL_SUFFIX")] InvalidTagInFinalUrlSuffix = 82,
        /// <summary>
        /// Final url suffix is formatted incorrectly.
        /// </summary>
        [pbr::OriginalName("INVALID_FINAL_URL_SUFFIX_FORMAT")] InvalidFinalUrlSuffixFormat = 83,
        /// <summary>
        /// Consent for call recording, which is required for the use of call
        /// extensions, was not provided by the advertiser. Please see
        /// https://support.google.com/google-ads/answer/7412639.
        /// </summary>
        [pbr::OriginalName("CUSTOMER_CONSENT_FOR_CALL_RECORDING_REQUIRED")] CustomerConsentForCallRecordingRequired = 84,
        /// <summary>
        /// Multiple message delivery options are set.
        /// </summary>
        [pbr::OriginalName("ONLY_ONE_DELIVERY_OPTION_IS_ALLOWED")] OnlyOneDeliveryOptionIsAllowed = 85,
        /// <summary>
        /// No message delivery option is set.
        /// </summary>
        [pbr::OriginalName("NO_DELIVERY_OPTION_IS_SET")] NoDeliveryOptionIsSet = 86,
        /// <summary>
        /// String value of conversion reporting state field is not valid.
        /// </summary>
        [pbr::OriginalName("INVALID_CONVERSION_REPORTING_STATE")] InvalidConversionReportingState = 87,
        /// <summary>
        /// Image size is not right.
        /// </summary>
        [pbr::OriginalName("IMAGE_SIZE_WRONG")] ImageSizeWrong = 88,
        /// <summary>
        /// Email delivery is not supported in the country specified in the country
        /// code field.
        /// </summary>
        [pbr::OriginalName("EMAIL_DELIVERY_NOT_AVAILABLE_IN_COUNTRY")] EmailDeliveryNotAvailableInCountry = 89,
        /// <summary>
        /// Auto reply is not supported in the country specified in the country code
        /// field.
        /// </summary>
        [pbr::OriginalName("AUTO_REPLY_NOT_AVAILABLE_IN_COUNTRY")] AutoReplyNotAvailableInCountry = 90,
        /// <summary>
        /// Invalid value specified for latitude.
        /// </summary>
        [pbr::OriginalName("INVALID_LATITUDE_VALUE")] InvalidLatitudeValue = 91,
        /// <summary>
        /// Invalid value specified for longitude.
        /// </summary>
        [pbr::OriginalName("INVALID_LONGITUDE_VALUE")] InvalidLongitudeValue = 92,
        /// <summary>
        /// Too many label fields provided.
        /// </summary>
        [pbr::OriginalName("TOO_MANY_LABELS")] TooManyLabels = 93,
        /// <summary>
        /// Invalid image url.
        /// </summary>
        [pbr::OriginalName("INVALID_IMAGE_URL")] InvalidImageUrl = 94,
        /// <summary>
        /// Latitude value is missing.
        /// </summary>
        [pbr::OriginalName("MISSING_LATITUDE_VALUE")] MissingLatitudeValue = 95,
        /// <summary>
        /// Longitude value is missing.
        /// </summary>
        [pbr::OriginalName("MISSING_LONGITUDE_VALUE")] MissingLongitudeValue = 96,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
