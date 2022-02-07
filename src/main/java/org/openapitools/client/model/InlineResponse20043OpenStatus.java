/*
 * Sendbird Platform SDK
 * Sendbird Platform API Javascript SDK  https://sendbird.com/docs/chat/v3/platform-api/getting-started/prepare-to-use-api
 *
 * The version of the OpenAPI document: 1.0.0
 * 
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */


package org.openapitools.client.model;

import java.util.Objects;
import java.util.Arrays;
import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModel;
import io.swagger.annotations.ApiModelProperty;
import java.io.IOException;

/**
 * InlineResponse20043OpenStatus
 */
@javax.annotation.Generated(value = "org.openapitools.codegen.languages.JavaClientCodegen", date = "2022-02-07T15:17:22.820442Z[Europe/London]")
public class InlineResponse20043OpenStatus {
  public static final String SERIALIZED_NAME_USER_ID = "user_id";
  @SerializedName(SERIALIZED_NAME_USER_ID)
  private String userId;

  public static final String SERIALIZED_NAME_CHANNEL_URL = "channel_url";
  @SerializedName(SERIALIZED_NAME_CHANNEL_URL)
  private String channelUrl;

  public static final String SERIALIZED_NAME_HAS_OPENED = "has_opened";
  @SerializedName(SERIALIZED_NAME_HAS_OPENED)
  private Boolean hasOpened;

  public InlineResponse20043OpenStatus() { 
  }

  public InlineResponse20043OpenStatus userId(String userId) {
    
    this.userId = userId;
    return this;
  }

   /**
   * Get userId
   * @return userId
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getUserId() {
    return userId;
  }


  public void setUserId(String userId) {
    this.userId = userId;
  }


  public InlineResponse20043OpenStatus channelUrl(String channelUrl) {
    
    this.channelUrl = channelUrl;
    return this;
  }

   /**
   * Get channelUrl
   * @return channelUrl
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public String getChannelUrl() {
    return channelUrl;
  }


  public void setChannelUrl(String channelUrl) {
    this.channelUrl = channelUrl;
  }


  public InlineResponse20043OpenStatus hasOpened(Boolean hasOpened) {
    
    this.hasOpened = hasOpened;
    return this;
  }

   /**
   * Get hasOpened
   * @return hasOpened
  **/
  @javax.annotation.Nullable
  @ApiModelProperty(value = "")

  public Boolean getHasOpened() {
    return hasOpened;
  }


  public void setHasOpened(Boolean hasOpened) {
    this.hasOpened = hasOpened;
  }


  @Override
  public boolean equals(Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    InlineResponse20043OpenStatus inlineResponse20043OpenStatus = (InlineResponse20043OpenStatus) o;
    return Objects.equals(this.userId, inlineResponse20043OpenStatus.userId) &&
        Objects.equals(this.channelUrl, inlineResponse20043OpenStatus.channelUrl) &&
        Objects.equals(this.hasOpened, inlineResponse20043OpenStatus.hasOpened);
  }

  @Override
  public int hashCode() {
    return Objects.hash(userId, channelUrl, hasOpened);
  }

  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class InlineResponse20043OpenStatus {\n");
    sb.append("    userId: ").append(toIndentedString(userId)).append("\n");
    sb.append("    channelUrl: ").append(toIndentedString(channelUrl)).append("\n");
    sb.append("    hasOpened: ").append(toIndentedString(hasOpened)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}
