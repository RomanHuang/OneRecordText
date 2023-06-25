﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecordAPI
{
    public class Vocabulary
    {

        public const string ONTOLOGY_IRI_api_generated = "https://onerecord.iata.org/api-generated";
        public const string ONTOLOGY_IRI_ = "https://onerecord.iata.org/api/";
        public const string s_c_Thing = "http://www.w3.org/2002/07/owl#Thing";
        //public final static IRI c_Thing = IRI.create(s_c_Thing);
        public const string s_c_Branch = "https://onerecord.iata.org/Branch";
        //public final static IRI c_Branch = IRI.create(s_c_Branch);
        public const string s_c_LogisticsObject = "https://onerecord.iata.org/LogisticsObject";
        //public final static IRI c_LogisticsObject = IRI.create(s_c_LogisticsObject);
        /**
         * Audit trail of a Logistics Object
         * 
         */
        public const string s_c_AuditTrail = "https://onerecord.iata.org/api/AuditTrail";
        //public final static IRI c_AuditTrail = IRI.create(s_c_AuditTrail);
        public const string s_c_Branch_A = "https://onerecord.iata.org/api/Branch";
        //public final static IRI c_Branch_A = IRI.create(s_c_Branch_A);
        /**
         * Change Request for the audit trail
         * 
         */
        public const string s_c_ChangeRequest = "https://onerecord.iata.org/api/ChangeRequest";
        //public final static IRI c_ChangeRequest = IRI.create(s_c_ChangeRequest);
        public const string s_c_Company = "https://onerecord.iata.org/api/Company";
        //public final static IRI c_Company = IRI.create(s_c_Company);
        /**
         * Company information in the Internet of Logistics
         * 
         */
        public const string s_c_CompanyInformation = "https://onerecord.iata.org/api/CompanyInformation";
        //public final static IRI c_CompanyInformation = IRI.create(s_c_CompanyInformation);
        /**
         * Delegation Request to 3rd parties
         * 
         */
        public const string s_c_DelegationRequest = "https://onerecord.iata.org/api/DelegationRequest";
        //public final static IRI c_DelegationRequest = IRI.create(s_c_DelegationRequest);
        /**
         * Error details
         * 
         */
        public const string s_c_Details = "https://onerecord.iata.org/api/Details";
        //public final static IRI c_Details = IRI.create(s_c_Details);
        /**
         * Error model
         * 
         */
        public const string s_c_Error = "https://onerecord.iata.org/api/Error";
        //public final static IRI c_Error = IRI.create(s_c_Error);
        public const string s_c_LogisticsObject_A = "https://onerecord.iata.org/api/LogisticsObject";
        //public final static IRI c_LogisticsObject_A = IRI.create(s_c_LogisticsObject_A);
        /**
         * Reference to a Logistics Object
         * 
         */
        public const string s_c_LogisticsObjectRef = "https://onerecord.iata.org/api/LogisticsObjectRef";
        //public final static IRI c_LogisticsObjectRef = IRI.create(s_c_LogisticsObjectRef);
        /**
         * Version of a Logistics Object
         * 
         */
        public const string s_c_Memento = "https://onerecord.iata.org/api/Memento";
        //public final static IRI c_Memento = IRI.create(s_c_Memento);
        /**
         * Memento entry from the time map
         * 
         */
        public const string s_c_MementoEntry = "https://onerecord.iata.org/api/MementoEntry";
        //public final static IRI c_MementoEntry = IRI.create(s_c_MementoEntry);
        /**
         * Memento list model
         * 
         */
        public const string s_c_MementoList = "https://onerecord.iata.org/api/MementoList";
        //public final static IRI c_MementoList = IRI.create(s_c_MementoList);
        /**
         * Memento list model
         * 
         */
        public const string s_c_Mementos = "https://onerecord.iata.org/api/Mementos";
        //public final static IRI c_Mementos = IRI.create(s_c_Mementos);
        /**
         * Notification sent by the publisher to the subscriber
         * 
         */
        public const string s_c_Notification = "https://onerecord.iata.org/api/Notification";
        //public final static IRI c_Notification = IRI.create(s_c_Notification);
        /**
         * Operation Request contained in the PATCH body
         * 
         */
        public const string s_c_Operation = "https://onerecord.iata.org/api/Operation";
        //public final static IRI c_Operation = IRI.create(s_c_Operation);
        /**
         * Object to modify in the PATCH request
         * 
         */
        public const string s_c_OperationObject = "https://onerecord.iata.org/api/OperationObject";
        //public final static IRI c_OperationObject = IRI.create(s_c_OperationObject);
        /**
         * PATCH Request body containing updates on a Logistics Object
         * 
         */
        public const string s_c_PatchRequest = "https://onerecord.iata.org/api/PatchRequest";
        //public final static IRI c_PatchRequest = IRI.create(s_c_PatchRequest);
        /**
         * Subscription information sent to the publisher
         * 
         */
        public const string s_c_Subscription = "https://onerecord.iata.org/api/Subscription";
        //public final static IRI c_Subscription = IRI.create(s_c_Subscription);
        /**
         * Timemap of a Logistics Object containing mementos and timegate URI
         * 
         */
        public const string s_c_Timemap = "https://onerecord.iata.org/api/Timemap";
        //public final static IRI c_Timemap = IRI.create(s_c_Timemap);
        /**
         * List of change requests that were sent as PATCH on for a Logistics Object
         * 
         */
        public const string s_p_changeRequests = "https://onerecord.iata.org/api/AuditTrail#changeRequests";
        //public final static IRI p_changeRequests = IRI.create(s_p_changeRequests);
        /**
         * Non mandatory error details
         * 
         */
        public const string s_p_errors = "https://onerecord.iata.org/api/AuditTrail#errors";
        //public final static IRI p_errors = IRI.create(s_p_errors);
        /**
         * Initial content of the Logistics Object at the creation moment, represented via a Memento
         * 
         */
        public const string s_p_loInitialSnapshot = "https://onerecord.iata.org/api/AuditTrail#loInitialSnapshot";
        //public final static IRI p_loInitialSnapshot = IRI.create(s_p_loInitialSnapshot);
        /**
         * Logistics Object Reference for which the audit trail applies
         * 
         */
        public const string s_p_logisticsObjectRef = "https://onerecord.iata.org/api/AuditTrail#logisticsObjectRef";
        //public final static IRI p_logisticsObjectRef = IRI.create(s_p_logisticsObjectRef);
        /**
         * PATCH body of a change request sent for a specific Logistics Object
         * 
         */
        public const string s_p_patchRequest = "https://onerecord.iata.org/api/ChangeRequest#patchRequest";
        //public final static IRI p_patchRequest = IRI.create(s_p_patchRequest);
        /**
         * The party that has requested the change request
         * 
         */
        public const string s_p_requestingParty = "https://onerecord.iata.org/api/ChangeRequest#requestingParty";
        //public final static IRI p_requestingParty = IRI.create(s_p_requestingParty);
        /**
         * Company details
         * 
         */
        public const string s_p_company = "https://onerecord.iata.org/api/CompanyInformation#company";
        //public final static IRI p_company = IRI.create(s_p_company);
        /**
         * Non mandatory error details
         * 
         */
        public const string s_p_errors_A = "https://onerecord.iata.org/api/CompanyInformation#errors";
        //public final static IRI p_errors_A = IRI.create(s_p_errors_A);
        /**
         * Identifiers of the logistics objects to which the access is requested
         * 
         */
        public const string s_p_targetLogisticsObjects = "https://onerecord.iata.org/api/DelegationRequest#targetLogisticsObjects";
        //public final static IRI p_targetLogisticsObjects = IRI.create(s_p_targetLogisticsObjects);
        /**
         * Error details
         * 
         */
        public const string s_p_details = "https://onerecord.iata.org/api/Error#details";
        //public final static IRI p_details = IRI.create(s_p_details);
        /**
         * The actual data
         * 
         */
        public const string s_p_data = "https://onerecord.iata.org/api/Memento#data";
        //public final static IRI p_data = IRI.create(s_p_data);
        /**
         * Link to the memento
         * 
         */
        public const string s_p_memento = "https://onerecord.iata.org/api/MementoEntry#memento";
        //public final static IRI p_memento = IRI.create(s_p_memento);
        /**
         * List of mementos of a Logistics Object
         * 
         */
        public const string s_p_mementoEntry = "https://onerecord.iata.org/api/MementoList#mementoEntry";
        //public final static IRI p_mementoEntry = IRI.create(s_p_mementoEntry);
        /**
         * List of mementos of a Logistics Object
         * 
         */
        public const string s_p_list = "https://onerecord.iata.org/api/Mementos#list";
        //public final static IRI p_list = IRI.create(s_p_list);
        /**
         * Logistics Object for which the notification is sent
         * 
         */
        public const string s_p_logisticsObject = "https://onerecord.iata.org/api/Notification#logisticsObject";
        //public final static IRI p_logisticsObject = IRI.create(s_p_logisticsObject);
        /**
         * PATCH object to modify
         * 
         */
        public const string s_p_o = "https://onerecord.iata.org/api/Operation#o";
        //public final static IRI p_o = IRI.create(s_p_o);
        /**
         * Reference of the Logistics Object to which the change request is applied to
         * 
         */
        public const string s_p_logisticsObjectRef_A = "https://onerecord.iata.org/api/PatchRequest#logisticsObjectRef";
        //public final static IRI p_logisticsObjectRef_A = IRI.create(s_p_logisticsObjectRef_A);
        /**
         * List of operations to apply as PATCH on a Logistics Object
         * 
         */
        public const string s_p_operations = "https://onerecord.iata.org/api/PatchRequest#operations";
        //public final static IRI p_operations = IRI.create(s_p_operations);
        /**
         * Non mandatory error details
         * 
         */
        public const string s_p_errors_A_A = "https://onerecord.iata.org/api/Subscription#errors";
        //public final static IRI p_errors_A_A = IRI.create(s_p_errors_A_A);
        /**
         * List of mementos of a Logistics Object
         * 
         */
        public const string s_p_mementos = "https://onerecord.iata.org/api/Timemap#mementos";
        //public final static IRI p_mementos = IRI.create(s_p_mementos);
        /**
         * Latest revision of the Logistics Object
         * 
         */
        public const string s_p_latestRevision = "https://onerecord.iata.org/api/AuditTrail#latestRevision";
        //public final static IRI p_latestRevision = IRI.create(s_p_latestRevision);
        /**
         * Company which sent the change request
         * 
         */
        public const string s_p_companyId = "https://onerecord.iata.org/api/ChangeRequest#companyId";
        //public final static IRI p_companyId = IRI.create(s_p_companyId);
        /**
         * ACCEPTED or REJECTED
         * 
         */
        public const string s_p_status = "https://onerecord.iata.org/api/ChangeRequest#status";
        //public final static IRI p_status = IRI.create(s_p_status);
        /**
         * Timestamp of the change request
         * 
         */
        public const string s_p_timestamp = "https://onerecord.iata.org/api/ChangeRequest#timestamp";
        //public final static IRI p_timestamp = IRI.create(s_p_timestamp);
        /**
         * Company Id, for example airline code.
         * 
         */
        public const string s_p_companyId_A = "https://onerecord.iata.org/api/CompanyInformation#companyId";
        //public final static IRI p_companyId_A = IRI.create(s_p_companyId_A);
        /**
         * Endpoint of the company in the Internet of Logistics
         * 
         */
        public const string s_p_serverEndpoint = "https://onerecord.iata.org/api/CompanyInformation#serverEndpoint";
        //public final static IRI p_serverEndpoint = IRI.create(s_p_serverEndpoint);
        /**
         * Supported content types of the server
         * 
         */
        public const string s_p_supportedContentTypes = "https://onerecord.iata.org/api/CompanyInformation#supportedContentTypes";
        //public final static IRI p_supportedContentTypes = IRI.create(s_p_supportedContentTypes);
        /**
         * Supported logistics object types on the server
         * 
         */
        public const string s_p_supportedLogisticsObjects = "https://onerecord.iata.org/api/CompanyInformation#supportedLogisticsObjects";
        //public final static IRI p_supportedLogisticsObjects = IRI.create(s_p_supportedLogisticsObjects);
        /**
         * REVOKE or DELEGATE
         * 
         */
        public const string s_p_action = "https://onerecord.iata.org/api/DelegationRequest#action";
        //public final static IRI p_action = IRI.create(s_p_action);
        /**
         * GET or PATCH
         * 
         */
        public const string s_p_operations_A = "https://onerecord.iata.org/api/DelegationRequest#operations";
        //public final static IRI p_operations_A = IRI.create(s_p_operations_A);
        /**
         * Parties that receive the delegated rights
         * 
         */
        public const string s_p_targetCompanies = "https://onerecord.iata.org/api/DelegationRequest#targetCompanies";
        //public final static IRI p_targetCompanies = IRI.create(s_p_targetCompanies);
        /**
         * Field of the object for which the error applies
         * 
         */
        public const string s_p_attribute = "https://onerecord.iata.org/api/Details#attribute";
        //public final static IRI p_attribute = IRI.create(s_p_attribute);
        /**
         * Error code
         * 
         */
        public const string s_p_code = "https://onerecord.iata.org/api/Details#code";
        //public final static IRI p_code = IRI.create(s_p_code);
        /**
         * Message of the error
         * 
         */
        public const string s_p_message = "https://onerecord.iata.org/api/Details#message";
        //public final static IRI p_message = IRI.create(s_p_message);
        /**
         * Object for which the error applies
         * 
         */
        public const string s_p_resource = "https://onerecord.iata.org/api/Details#resource";
        //public final static IRI p_resource = IRI.create(s_p_resource);
        /**
         * Brief description of the error
         * 
         */
        public const string s_p_title = "https://onerecord.iata.org/api/Error#title";
        //public final static IRI p_title = IRI.create(s_p_title);
        /**
         * Id of the reference Logistics Object
         * 
         */
        public const string s_p_logisticsObjectId = "https://onerecord.iata.org/api/LogisticsObjectRef#logisticsObjectId";
        //public final static IRI p_logisticsObjectId = IRI.create(s_p_logisticsObjectId);
        /**
         * Type of the reference Logistics Object
         * 
         */
        public const string s_p_logisticsObjectType = "https://onerecord.iata.org/api/LogisticsObjectRef#logisticsObjectType";
        //public final static IRI p_logisticsObjectType = IRI.create(s_p_logisticsObjectType);
        /**
         * Date and time of the memento creation
         * 
         */
        public const string s_p_created = "https://onerecord.iata.org/api/Memento#created";
        //public final static IRI p_created = IRI.create(s_p_created);
        /**
         * Name of the memento creator
         * 
         */
        public const string s_p_createdBy = "https://onerecord.iata.org/api/Memento#createdBy";
        //public final static IRI p_createdBy = IRI.create(s_p_createdBy);
        /**
         * Label of the memento
         * 
         */
        public const string s_p_label = "https://onerecord.iata.org/api/Memento#label";
        //public final static IRI p_label = IRI.create(s_p_label);
        /**
         * First version of the Logistics Object
         * 
         */
        public const string s_p_original = "https://onerecord.iata.org/api/Memento#original";
        //public final static IRI p_original = IRI.create(s_p_original);
        /**
         * Creation date of the memento
         * 
         */
        public const string s_p_datetime = "https://onerecord.iata.org/api/MementoEntry#datetime";
        //public final static IRI p_datetime = IRI.create(s_p_datetime);
        /**
         * Non mandatory label of the memento
         * 
         */
        public const string s_p_label_A = "https://onerecord.iata.org/api/MementoEntry#label";
        //public final static IRI p_label_A = IRI.create(s_p_label_A);
        /**
         * First memento of the Logistics Object
         * 
         */
        public const string s_p_firstMemento = "https://onerecord.iata.org/api/Mementos#firstMemento";
        //public final static IRI p_firstMemento = IRI.create(s_p_firstMemento);
        /**
         * Last memento of the Logistics Object
         * 
         */
        public const string s_p_lastMemento = "https://onerecord.iata.org/api/Mementos#lastMemento";
        //public final static IRI p_lastMemento = IRI.create(s_p_lastMemento);
        /**
         * OBJECT_CREATED or OBJECT_UPDATED
         * 
         */
        public const string s_p_eventType = "https://onerecord.iata.org/api/Notification#eventType";
        //public final static IRI p_eventType = IRI.create(s_p_eventType);
        /**
         * Type of Logistics Object
         * 
         */
        public const string s_p_topic = "https://onerecord.iata.org/api/Notification#topic";
        //public final static IRI p_topic = IRI.create(s_p_topic);
        /**
         * Operation objects must have exactly one op (operation) member; this value indicates which operation is to be performed. The value must be one of add or del; all other values result in an error
         * 
         */
        public const string s_p_op = "https://onerecord.iata.org/api/Operation#op";
        //public final static IRI p_op = IRI.create(s_p_op);
        /**
         * Operations objects must have exactly one p, predicate, member. The value of this member must be an IRI
         * 
         */
        public const string s_p_p = "https://onerecord.iata.org/api/Operation#p";
        //public final static IRI p_p = IRI.create(s_p_p);
        /**
         * Data type of the field to update
         * 
         */
        public const string s_p_datatype = "https://onerecord.iata.org/api/OperationObject#datatype";
        //public final static IRI p_datatype = IRI.create(s_p_datatype);
        /**
         * Value to update
         * 
         */
        public const string s_p_value = "https://onerecord.iata.org/api/OperationObject#value";
        //public final static IRI p_value = IRI.create(s_p_value);
        /**
         * Reason for the change (optional)
         * 
         */
        public const string s_p_description = "https://onerecord.iata.org/api/PatchRequest#description";
        //public final static IRI p_description = IRI.create(s_p_description);
        /**
         * The company identifier of the entity that is requesting the change request
         * 
         */
        public const string s_p_requestorCompanyIdentifier = "https://onerecord.iata.org/api/PatchRequest#requestorCompanyIdentifier";
        //public final static IRI p_requestorCompanyIdentifier = IRI.create(s_p_requestorCompanyIdentifier);
        /**
         * Revision number of the Logistics Object
         * 
         */
        public const string s_p_revision = "https://onerecord.iata.org/api/PatchRequest#revision";
        //public final static IRI p_revision = IRI.create(s_p_revision);
        /**
         * Duration of the period to cache the subscription information in seconds
         * 
         */
        public const string s_p_cacheFor = "https://onerecord.iata.org/api/Subscription#cacheFor";
        //public final static IRI p_cacheFor = IRI.create(s_p_cacheFor);
        /**
         * Callback URL of the Client Subscription API where the subscriber receives Logistics Objects
         * 
         */
        public const string s_p_callbackUrl = "https://onerecord.iata.org/api/Subscription#callbackUrl";
        //public final static IRI p_callbackUrl = IRI.create(s_p_callbackUrl);
        /**
         * Content types that the subscriber wants to receive in the notifications
         * 
         */
        public const string s_p_contentTypes = "https://onerecord.iata.org/api/Subscription#contentTypes";
        //public final static IRI p_contentTypes = IRI.create(s_p_contentTypes);
        /**
         * The company identifier from the Internet of Logistics of my company.
         * 
         */
        public const string s_p_myCompanyIdentifier = "https://onerecord.iata.org/api/Subscription#myCompanyIdentifier";
        //public final static IRI p_myCompanyIdentifier = IRI.create(s_p_myCompanyIdentifier);
        /**
         * Either a secret or API Key that ensures that only companies with this subscription information can POST to the subscriber callback endpoint
         * 
         */
        public const string s_p_secret = "https://onerecord.iata.org/api/Subscription#secret";
        //public final static IRI p_secret = IRI.create(s_p_secret);
        /**
         * Flag specifying if the publisher should send the whole logistics object or not in the notification object
         * 
         */
        public const string s_p_sendLogisticsObjectBody = "https://onerecord.iata.org/api/Subscription#sendLogisticsObjectBody";
        //public final static IRI p_sendLogisticsObjectBody = IRI.create(s_p_sendLogisticsObjectBody);
        /**
         * Flag specifying if the subscriber wants to receive updates for a Logistics Object
         * 
         */
        public const string s_p_subscribeToStatusUpdates = "https://onerecord.iata.org/api/Subscription#subscribeToStatusUpdates";
        //public final static IRI p_subscribeToStatusUpdates = IRI.create(s_p_subscribeToStatusUpdates);
        /**
         * Company Identifier of the company the subscriber wants to subscribe to (delegation scenario).
         * 
         */
        public const string s_p_subscribedTo = "https://onerecord.iata.org/api/Subscription#subscribedTo";
        //public final static IRI p_subscribedTo = IRI.create(s_p_subscribedTo);
        /**
         * The Logistics Object type to which the subscriber wants subscribe to
         * 
         */
        public const string s_p_topic_A = "https://onerecord.iata.org/api/Subscription#topic";
        //public final static IRI p_topic_A = IRI.create(s_p_topic_A);
        /**
         * Link to the initial version of the Logistics Object
         * 
         */
        public const string s_p_original_A = "https://onerecord.iata.org/api/Timemap#original";
        //public final static IRI p_original_A = IRI.create(s_p_original_A);
        /**
         * Link to the time gate of the Logistics Object, if applicable
         * 
         */
        public const string s_p_timegate = "https://onerecord.iata.org/api/Timemap#timegate";
        //public final static IRI p_timegate = IRI.create(s_p_timegate);
        public const string s_p_description_A = "http://purl.org/dc/elements/1.1/description";
        //public final static IRI p_description_A = IRI.create(s_p_description_A);
        public const string s_p_title_A = "http://purl.org/dc/elements/1.1/title";
        //public final static IRI p_title_A = IRI.create(s_p_title_A);
        public const string s_p_comment = "http://www.w3.org/2000/01/rdf-schema#comment";
        //public final static IRI p_comment = IRI.create(s_p_comment);
        public const string s_p_label_A_A = "http://www.w3.org/2000/01/rdf-schema#label";
        //public final static IRI p_label_A_A = IRI.create(s_p_label_A_A);



    }
}
