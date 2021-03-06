/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateItem operation.
    /// <para> Edits an existing item's attributes, or inserts a new item if it does not already exist. You can put, delete, or add attribute
    /// values. You can also perform a conditional update (insert a new attribute name-value pair if it doesn't exist, or replace an existing
    /// name-value pair if it has certain expected attribute values).</para> <para>In addition to updating an item, you can also return the item's
    /// attribute values in the same operation, using the <i>ReturnValues</i> parameter.</para>
    /// </summary>
    public partial class UpdateItemRequest : AmazonDynamoDBv2Request
    {
        private string tableName;
        private Dictionary<string,AttributeValue> key = new Dictionary<string,AttributeValue>();
        private Dictionary<string,AttributeValueUpdate> attributeUpdates = new Dictionary<string,AttributeValueUpdate>();
        private Dictionary<string,ExpectedAttributeValue> expected = new Dictionary<string,ExpectedAttributeValue>();
        private ConditionalOperator conditionalOperator;
        private ReturnValue returnValues;
        private ReturnConsumedCapacity returnConsumedCapacity;
        private ReturnItemCollectionMetrics returnItemCollectionMetrics;


        /// <summary>
        /// The name of the table containing the item to update.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>3 - 255</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[a-zA-Z0-9_.-]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string TableName
        {
            get { return this.tableName; }
            set { this.tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this.tableName != null;
        }

        /// <summary>
        /// The primary key that defines the item. Each element consists of an attribute name and a value for that attribute.
        ///  
        /// </summary>
        public Dictionary<string,AttributeValue> Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.key != null;
        }

        /// <summary>
        /// The names of attributes to be modified, the action to perform on each, and the new value for each. If you are updating an attribute that is
        /// an index key attribute for any indexes on that table, the attribute type must match the index key type defined in the
        /// <i>AttributesDefinition</i> of the table description. You can use <i>UpdateItem</i> to update any non-key attributes. Attribute values
        /// cannot be null. String and binary type attributes must have lengths greater than zero. Set type attributes must not be empty. Requests with
        /// empty values will be rejected with a <i>ValidationException</i>. Each <i>AttributeUpdates</i> element consists of an attribute name to
        /// modify, along with the following: <ul> <li> <i>Value</i> - The new value, if applicable, for this attribute. </li> <li> <i>Action</i> -
        /// Specifies how to perform the update. Valid values for <i>Action</i> are <c>PUT</c>, <c>DELETE</c>, and <c>ADD</c>. The behavior depends on
        /// whether the specified primary key already exists in the table. <b>If an item with the specified <i>Key</i> is found in the table:</b> <ul>
        /// <li> <c>PUT</c> - Adds the specified attribute to the item. If the attribute already exists, it is replaced by the new value. </li> <li>
        /// <c>DELETE</c> - If no value is specified, the attribute and its value are removed from the item. The data type of the specified value must
        /// match the existing value's data type. If a <i>set</i> of values is specified, then those values are subtracted from the old set. For
        /// example, if the attribute value was the set <c>[a,b,c]</c> and the <i>DELETE</i> action specified <c>[a,c]</c>, then the final attribute
        /// value would be <c>[b]</c>. Specifying an empty set is an error. </li> <li> <c>ADD</c> - If the attribute does not already exist, then the
        /// attribute and its values are added to the item. If the attribute does exist, then the behavior of <c>ADD</c> depends on the data type of the
        /// attribute: <ul> <li> If the existing attribute is a number, and if <i>Value</i> is also a number, then the <i>Value</i> is mathematically
        /// added to the existing attribute. If <i>Value</i> is a negative number, then it is subtracted from the existing attribute. <note> If you use
        /// <c>ADD</c> to increment or decrement a number value for an item that doesn't exist before the update, DynamoDB uses 0 as the initial value.
        /// In addition, if you use <c>ADD</c> to update an existing item, and intend to increment or decrement an attribute value which does not yet
        /// exist, DynamoDB uses <c>0</c> as the initial value. For example, suppose that the item you want to update does not yet have an attribute
        /// named <i>itemcount</i>, but you decide to <c>ADD</c> the number <c>3</c> to this attribute anyway, even though it currently does not exist.
        /// DynamoDB will create the <i>itemcount</i> attribute, set its initial value to <c>0</c>, and finally add <c>3</c> to it. The result will be a
        /// new <i>itemcount</i> attribute in the item, with a value of <c>3</c>. </note> </li> <li> If the existing data type is a set, and if the
        /// <i>Value</i> is also a set, then the <i>Value</i> is added to the existing set. (This is a <i>set</i> operation, not mathematical addition.)
        /// For example, if the attribute value was the set <c>[1,2]</c>, and the <c>ADD</c> action specified <c>[3]</c>, then the final attribute value
        /// would be <c>[1,2,3]</c>. An error occurs if an Add action is specified for a set attribute and the attribute type specified does not match
        /// the existing set type. Both sets must have the same primitive data type. For example, if the existing data type is a set of strings, the
        /// <i>Value</i> must also be a set of strings. The same holds true for number sets and binary sets. </li> </ul> This action is only valid for
        /// an existing attribute whose data type is number or is a set. Do not use <c>ADD</c> for any other data types. </li> </ul> <b>If no item with
        /// the specified <i>Key</i> is found:</b> <ul> <li> <c>PUT</c> - DynamoDB creates a new item with the specified primary key, and then adds the
        /// attribute. </li> <li> <c>DELETE</c> - Nothing happens; there is no attribute to delete. </li> <li> <c>ADD</c> - DynamoDB creates an item
        /// with the supplied primary key and number (or set of numbers) for the attribute value. The only data types allowed are number and number set;
        /// no other data types can be specified. </li> </ul> </li> </ul> If you specify any attributes that are part of an index key, then the data
        /// types for those attributes must match those of the schema in the table's attribute definition.
        ///  
        /// </summary>
        public Dictionary<string,AttributeValueUpdate> AttributeUpdates
        {
            get { return this.attributeUpdates; }
            set { this.attributeUpdates = value; }
        }

        // Check to see if AttributeUpdates property is set
        internal bool IsSetAttributeUpdates()
        {
            return this.attributeUpdates != null;
        }

        /// <summary>
        /// A map of attribute/condition pairs. This is the conditional block for the <i>UpdateItem</i> operation. All the conditions must evaluate to
        /// true for the operation to succeed. <i>Expected</i> allows you to provide an attribute name, and whether or not DynamoDB should check to see
        /// if the attribute value already exists; or if the attribute value exists and has a particular value before changing it. Each item in
        /// <i>Expected</i> represents an attribute name for DynamoDB to check, along with the following: <ul> <li> <i>Value</i> - A value for DynamoDB
        /// to compare with an attribute. When performing the comparison, strongly consistent reads are used. </li> <li> <i>Exists</i> - Causes DynamoDB
        /// to evaluate the value before attempting a conditional operation: <ul> <li> If <i>Exists</i> is <c>true</c>, DynamoDB will check to see if
        /// that attribute value already exists in the table. If it is found, then the operation succeeds. If it is not found, the operation fails with
        /// a <i>ConditionalCheckFailedException</i>. </li> <li> If <i>Exists</i> is <c>false</c>, DynamoDB assumes that the attribute value does
        /// <i>not</i> exist in the table. If in fact the value does not exist, then the assumption is valid and the operation succeeds. If the value is
        /// found, despite the assumption that it does not exist, the operation fails with a <i>ConditionalCheckFailedException</i>. </li> </ul> The
        /// default setting for <i>Exists</i> is <c>true</c>. If you supply a <i>Value</i> all by itself, DynamoDB assumes the attribute exists: You
        /// don't have to set <i>Exists</i> to <c>true</c>, because it is implied. DynamoDB returns a <i>ValidationException</i> if: <ul> <li>
        /// <i>Exists</i> is <c>true</c> but there is no <i>Value</i> to check. (You expect a value to exist, but don't specify what that value is.)
        /// </li> <li> <i>Exists</i> is <c>false</c> but you also specify a <i>Value</i>. (You cannot expect an attribute to have a value, while also
        /// expecting it not to exist.) </li> </ul> </li> </ul> If you specify more than one condition in the <i>Expected</i> map, then by default all
        /// of the conditions must evaluate to true. In other words, the conditions are ANDed together. (You can use the <i>ConditionalOperator</i>
        /// parameter to OR the conditions instead. If you do this, then at least one of the conditions must evaluate to true, rather than all of them.)
        /// If <i>Expected</i> evaluates to true, then the conditional operation succeeds; otherwise, it fails.
        ///  
        /// </summary>
        public Dictionary<string,ExpectedAttributeValue> Expected
        {
            get { return this.expected; }
            set { this.expected = value; }
        }

        // Check to see if Expected property is set
        internal bool IsSetExpected()
        {
            return this.expected != null;
        }

        /// <summary>
        /// A logical operator to apply to the conditions in the <i>Expected</i> map: <ul> <li><c>AND</c> - If <i>all</i> of the conditions evaluate to
        /// true, then the entire map evaluates to true.</li> <li><c>OR</c> - If <i>at least one</i> of the conditions evaluate to true, then the entire
        /// map evaluates to true.</li> </ul> If you omit <i>ConditionalOperator</i>, then <c>AND</c> is used as the default. The operation will succeed
        /// only if the entire map evaluates to true.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>AND, OR</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ConditionalOperator ConditionalOperator
        {
            get { return this.conditionalOperator; }
            set { this.conditionalOperator = value; }
        }

        // Check to see if ConditionalOperator property is set
        internal bool IsSetConditionalOperator()
        {
            return this.conditionalOperator != null;
        }

        /// <summary>
        /// Use <i>ReturnValues</i> if you want to get the item attributes as they appeared either before or after they were updated. For
        /// <i>UpdateItem</i>, the valid values are: <ul> <li> <c>NONE</c> - If <i>ReturnValues</i> is not specified, or if its value is <c>NONE</c>,
        /// then nothing is returned. (This is the default for <i>ReturnValues</i>.) </li> <li> <c>ALL_OLD</c> - If <i>UpdateItem</i> overwrote an
        /// attribute name-value pair, then the content of the old item is returned. </li> <li> <c>UPDATED_OLD</c> - The old versions of only the
        /// updated attributes are returned. </li> <li> <c>ALL_NEW</c> - All of the attributes of the new version of the item are returned. </li> <li>
        /// <c>UPDATED_NEW</c> - The new versions of only the updated attributes are returned. </li> </ul>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>NONE, ALL_OLD, UPDATED_OLD, ALL_NEW, UPDATED_NEW</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ReturnValue ReturnValues
        {
            get { return this.returnValues; }
            set { this.returnValues = value; }
        }

        // Check to see if ReturnValues property is set
        internal bool IsSetReturnValues()
        {
            return this.returnValues != null;
        }

        /// <summary>
        /// If set to <c>TOTAL</c>, the response includes <i>ConsumedCapacity</i> data for tables and indexes. If set to <c>INDEXES</c>, the response
        /// includes <i>ConsumedCapacity</i> for indexes. If set to <c>NONE</c> (the default), <i>ConsumedCapacity</i> is not included in the response.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>INDEXES, TOTAL, NONE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ReturnConsumedCapacity ReturnConsumedCapacity
        {
            get { return this.returnConsumedCapacity; }
            set { this.returnConsumedCapacity = value; }
        }

        // Check to see if ReturnConsumedCapacity property is set
        internal bool IsSetReturnConsumedCapacity()
        {
            return this.returnConsumedCapacity != null;
        }

        /// <summary>
        /// If set to <c>SIZE</c>, statistics about item collections, if any, that were modified during the operation are returned in the response. If
        /// set to <c>NONE</c> (the default), no statistics are returned.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>SIZE, NONE</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ReturnItemCollectionMetrics ReturnItemCollectionMetrics
        {
            get { return this.returnItemCollectionMetrics; }
            set { this.returnItemCollectionMetrics = value; }
        }

        // Check to see if ReturnItemCollectionMetrics property is set
        internal bool IsSetReturnItemCollectionMetrics()
        {
            return this.returnItemCollectionMetrics != null;
        }

    }
}
    
