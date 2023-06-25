using System;
using System.Collections.Generic;
using System.Text;

namespace OneRecordText.Model.OneRecord
{
    public class Vocabulary
    {

        public const string ONTOLOGY_IRI_ = "https://onerecord.iata.org/ns/cargo/";
        public const string ONTOLOGY_IRI_cargo_generated = "https://onerecord.iata.org/ns/cargo/cargo/-generated";
        public const string s_c_Thing = "http://www.w3.org/2002/07/owl#Thing";

        /**
         * Address details
         * 
         */
        public const string s_c_Address = "https://onerecord.iata.org/ns/cargo/Address";
        
        /**
         * Booking details - Deprecated, BookingOption should be used instead
         * 
         */
        public const string s_c_Booking = "https://onerecord.iata.org/ns/cargo/";
       
        /**
         * Booking details
         * 
         */
        public const string s_c_BookingOption = "https://onerecord.iata.org/ns/cargo/";
        
        /**
         * Request object, refers to the Quote request or Booking request 
         * 
         */
        public const string s_c_BookingOptionRequest = "https://onerecord.iata.org/ns/cargo/";

        /**
         * Booking Segment refers to the arrival and location details of a Booking Option Request or a Booking Option (offer or actual booking)
         * 
         */
        public const string s_c_BookingSegment = "https://onerecord.iata.org/ns/cargo/Segment";
        
        /**
         * Previsouly called Schedule. This object refers to times used for the Booking Option Request (preferences part of the request) or the Booking Option (times sur as LAT where there is a commitment from the carrier)
         * 
         */
        public const string s_c_BookingTimes = "https://onerecord.iata.org/ns/cargo/Times";
        //public final static IRI c_BookingTimes = IRI.create(s_c_BookingTimes);
        /**
         * Company branches
         * 
         */
        public const string s_c_Branch = "https://onerecord.iata.org/ns/cargo/Branch";
        //public final static IRI c_Branch = IRI.create(s_c_Branch);
        /**
         * CO2 calculation methods
         * 
         */
        public const string s_c_CO2CalcMethod = "https://onerecord.iata.org/ns/cargo/CO2CalcMethod";
        //public final static IRI c_CO2CalcMethod = IRI.create(s_c_CO2CalcMethod);
        /**
         * CO2 Calculation
         * 
         */
        public const string s_c_CO2Emissions = "https://onerecord.iata.org/ns/cargo/CO2Emissions";
        //public final static IRI c_CO2Emissions = IRI.create(s_c_CO2Emissions);
        /**
         * Company details of carriers
         * 
         */
        public const string s_c_Carrier = "https://onerecord.iata.org/ns/cargo/Carrier";
        //public final static IRI c_Carrier = IRI.create(s_c_Carrier);
        /**
         * Carrier product details
         * 
         */
        public const string s_c_CarrierProduct = "https://onerecord.iata.org/ns/cargo/CarrierProduct";
        //public final static IRI c_CarrierProduct = IRI.create(s_c_CarrierProduct);
        /**
         * Product additional details
         * 
         */
        public const string s_c_Characteristics = "https://onerecord.iata.org/ns/cargo/Characteristics";
        //public final static IRI c_Characteristics = IRI.create(s_c_Characteristics);
        public const string s_c_CommonObjects = "https://onerecord.iata.org/ns/cargo/CommonObjects";
        //public final static IRI c_CommonObjects = IRI.create(s_c_CommonObjects);
        /**
         * Company details
         * 
         */
        public const string s_c_Company = "https://onerecord.iata.org/ns/cargo/Company";
        //public final static IRI c_Company = IRI.create(s_c_Company);
        /**
         * Company branches
         * 
         */
        public const string s_c_CompanyBranch = "https://onerecord.iata.org/ns/cargo";
        //public final static IRI c_CompanyBranch = IRI.create(s_c_CompanyBranch);
        /**
         * Contact details
         * 
         */
        public const string s_c_Contact = "https://onerecord.iata.org/ns/cargo/Contact";
        //public final static IRI c_Contact = IRI.create(s_c_Contact);
        /**
         * Other contact options e.g. Skype, Whatsapp, Viber, Fax etc
         * 
         */
        public const string s_c_ContactOther = "https://onerecord.iata.org/ns/cargo/ContactOther";
        //public final static IRI c_ContactOther = IRI.create(s_c_ContactOther);
        /**
         * Country details
         * 
         */
        public const string s_c_Country = "https://onerecord.iata.org/ns/cargo/Country";
        //public final static IRI c_Country = IRI.create(s_c_Country);
        /**
         * Customs information details
         * 
         */
        public const string s_c_CustomsInfo = "https://onerecord.iata.org/ns/cargo/CustomsInfo";
        //public final static IRI c_CustomsInfo = IRI.create(s_c_CustomsInfo);
        /**
         * Dangerous goods declaration
         * 
         */
        public const string s_c_DgDeclaration = "https://onerecord.iata.org/ns/cargo/DgDeclaration";
        //public final static IRI c_DgDeclaration = IRI.create(s_c_DgDeclaration);
        /**
         * Details of the radioactive products 
         * 
         */
        public const string s_c_DgProductRadioactive = "https://onerecord.iata.org/ns/cargo/DgProductRadioactive";
        //public final static IRI c_DgProductRadioactive = IRI.create(s_c_DgProductRadioactive);
        /**
         * Details of the radioactive isotope contained in the product
         * 
         */
        public const string s_c_DgRadioactiveIsotope = "https://onerecord.iata.org/ns/cargo/DgRadioactiveIsotope";
        //public final static IRI c_DgRadioactiveIsotope = IRI.create(s_c_DgRadioactiveIsotope);
        /**
         * Dimension details
         * 
         */
        public const string s_c_Dimensions = "https://onerecord.iata.org/ns/cargo/Dimensions";
        //public final static IRI c_Dimensions = IRI.create(s_c_Dimensions);
        /**
         * Embedded Object parent class, containing all common properties for Embedded Object
         * 
         */
        public const string s_c_EmbeddedObject = "https://onerecord.iata.org/ns/cargo/EmbeddedObject";
        //public final static IRI c_EmbeddedObject = IRI.create(s_c_EmbeddedObject);
        /**
         * Details of the pieces (Live animals) of the permit and specific information such as quantity measured and used to date quota
         * 
         */
        public const string s_c_EpermitConsignment = "https://onerecord.iata.org/ns/cargo/EpermitConsignment";
        //public final static IRI c_EpermitConsignment = IRI.create(s_c_EpermitConsignment);
        /**
         * Signature details of the Epermit for Live Animals
         * 
         */
        public const string s_c_EpermitSignature = "https://onerecord.iata.org/ns/cargo/EpermitSignature";
        //public final static IRI c_EpermitSignature = IRI.create(s_c_EpermitSignature);
        /**
         * Event details
         * 
         */
        public const string s_c_Event = "https://onerecord.iata.org/ns/cargo/Event";
        //public final static IRI c_Event = IRI.create(s_c_Event);
        /**
         * Subtype of Event
         * 
         */
        public const string s_c_EventUld = "https://onerecord.iata.org/ns/cargo/EventUld";
        //public final static IRI c_EventUld = IRI.create(s_c_EventUld);
        /**
         * Reference documents details
         * 
         */
        public const string s_c_ExternalReference = "https://onerecord.iata.org/ns/cargo/ExternalReference";
        //public final static IRI c_ExternalReference = IRI.create(s_c_ExternalReference);
        /**
         * Geolocation details - e.g. for drones, automated vehicles...
         * 
         */
        public const string s_c_Geolocation = "https://onerecord.iata.org/ns/cargo/Geolocation";
        //public final static IRI c_Geolocation = IRI.create(s_c_Geolocation);
        /**
         * Used to provide handling instructions such as Special service request (SSR), Special handling codes (SPH) or Other service information (OSI)
         * 
         */
        public const string s_c_HandlingInstructions = "https://onerecord.iata.org/ns/cargo/HandlingInstructions";
        //public final static IRI c_HandlingInstructions = IRI.create(s_c_HandlingInstructions);
        /**
         * Insurance details
         * 
         */
        public const string s_c_Insurance = "https://onerecord.iata.org/ns/cargo/Insurance";
        //public final static IRI c_Insurance = IRI.create(s_c_Insurance);
        /**
         * IoT Device details
         * 
         */
        public const string s_c_IotDevice = "https://onerecord.iata.org/ns/cargo/IotDevice";
        //public final static IRI c_IotDevice = IRI.create(s_c_IotDevice);
        /**
         * Item details
         * 
         */
        public const string s_c_Item = "https://onerecord.iata.org/ns/cargo/Item";
        //public final static IRI c_Item = IRI.create(s_c_Item);
        /**
         * Dangerous Goods subtype of Item
         * 
         */
        public const string s_c_ItemDg = "https://onerecord.iata.org/ns/cargo/ItemDg";
        //public final static IRI c_ItemDg = IRI.create(s_c_ItemDg);
        /**
         * Epermit for Live Animals details
         * 
         */
        public const string s_c_LiveAnimalsEpermit = "https://onerecord.iata.org/ns/cargo/LiveAnimalsEpermit";
        //public final static IRI c_LiveAnimalsEpermit = IRI.create(s_c_LiveAnimalsEpermit);
        /**
         * Loading location details
         * 
         */
        public const string s_c_Location = "https://onerecord.iata.org/ns/cargo/Location";
        //public final static IRI c_Location = IRI.create(s_c_Location);
        /**
         * Logistics Object parent class, containing all common properties for logistics objects.
         * 
         */
        public const string s_c_LogisticsObject = "https://onerecord.iata.org/ns/cargo/LogisticsObject";
        //public final static IRI c_LogisticsObject = IRI.create(s_c_LogisticsObject);
        /**
         * Measurements details for Sensors, either generic or geolocation measurements are recorded
         * 记录传感器的测量详细信息，无论是通用测量还是地理位置测量
         */
        public const string s_c_Measurements = "https://onerecord.iata.org/ns/cargo/Measurements";
        //public final static IRI c_Measurements = IRI.create(s_c_Measurements);
        /**
         * Measurements details for Geolocation sensors
         * 地理位置传感器的测量详细信息
         */
        public const string s_c_MeasurementsGeoloc = "https://onerecord.iata.org/ns/cargo/MeasurementsGeoloc";
        //public final static IRI c_MeasurementsGeoloc = IRI.create(s_c_MeasurementsGeoloc);
        /**
         * Measurements details for sensors that are not geolocation sensors
         * 
         */
        public const string s_c_MeasurementsOther = "https://onerecord.iata.org/ns/cargo/MeasurementsOther";
        //public final static IRI c_MeasurementsOther = IRI.create(s_c_MeasurementsOther);
        /**
         * Times refering to Transport Movements, used to describe specfic times such as Actual Departure time, etc.
         * 
         */
        public const string s_c_MovementTimes = "https://onerecord.iata.org/ns/cargo/MovementTimes";
        //public final static IRI c_MovementTimes = IRI.create(s_c_MovementTimes);
        /**
         * Other identifiers
         * 
         */
        public const string s_c_OtherIdentifier = "https://onerecord.iata.org/ns/cargo/OtherIdentifier";
        //public final static IRI c_OtherIdentifier = IRI.create(s_c_OtherIdentifier);
        /**
         * Company details
         * 
         */
        public const string s_c_OtherParty = "https://onerecord.iata.org/ns/cargo/OtherParty";
        //public final static IRI c_OtherParty = IRI.create(s_c_OtherParty);
        /**
         * Packaging details 
         * 
         */
        public const string s_c_PackagingType = "https://onerecord.iata.org/ns/cargo/PackagingType";
        //public final static IRI c_PackagingType = IRI.create(s_c_PackagingType);
        /**
         * Refers to a Company and its role in a specific context, e.g Company A as shipper. cargo/-XML Code List 1.15 can be used as a reference with the addition of "Notify Party"
         * 
         */
        public const string s_c_Party = "https://onerecord.iata.org/ns/cargo/Party";
        //public final static IRI c_Party = IRI.create(s_c_Party);
        /**
         * Person details
         * 
         */
        public const string s_c_Person = "https://onerecord.iata.org/ns/cargo/Person";
        //public final static IRI c_Person = IRI.create(s_c_Person);
        /**
         * Individual piece or virtual grouping of pieces
         * 
         */
        public const string s_c_Piece = "https://onerecord.iata.org/ns/cargo";
        //public final static IRI c_Piece = IRI.create(s_c_Piece);
        /**
         * Dangerous Goods subtype of Piece
         * 
         */
        public const string s_c_PieceDg = "https://onerecord.iata.org/ns/cargoDg";
        //public final static IRI c_PieceDg = IRI.create(s_c_PieceDg);
        /**
         * LiveAnimals subclass of Piece
         * 
         */
        public const string s_c_PieceLiveAnimals = "https://onerecord.iata.org/ns/cargoLiveAnimals";
        //public final static IRI c_PieceLiveAnimals = IRI.create(s_c_PieceLiveAnimals);
        /**
         * Price associated to the offer/booking
         * 
         */
        public const string s_c_Price = "https://onerecord.iata.org/ns/cargo/Price";
        //public final static IRI c_Price = IRI.create(s_c_Price);
        /**
         * Product details
         * 
         */
        public const string s_c_Product = "https://onerecord.iata.org/ns/cargo/Product";
        //public final static IRI c_Product = IRI.create(s_c_Product);
        /**
         * Dangerous Goods subtype of Product
         * 
         */
        public const string s_c_ProductDg = "https://onerecord.iata.org/ns/cargo/ProductDg";
        //public final static IRI c_ProductDg = IRI.create(s_c_ProductDg);
        /**
         * Ranges details
         * 
         */
        public const string s_c_Ranges = "https://onerecord.iata.org/ns/cargo/Ranges";
        //public final static IRI c_Ranges = IRI.create(s_c_Ranges);
        /**
         * Ratings details
         * 
         */
        public const string s_c_Ratings = "https://onerecord.iata.org/ns/cargo/Ratings";
        //public final static IRI c_Ratings = IRI.create(s_c_Ratings);
        /**
         * Regulated Entity
         * 
         */
        public const string s_c_RegulatedEntity = "https://onerecord.iata.org/ns/cargo/RegulatedEntity";
        //public final static IRI c_RegulatedEntity = IRI.create(s_c_RegulatedEntity);
        /**
         * Request object, refers to the Quote request or Booking request 
         * 
         */
        public const string s_c_Request = "https://onerecord.iata.org/ns/cargo/Request";
        //public final static IRI c_Request = IRI.create(s_c_Request);
        /**
         * Routing details
         * 
         */
        public const string s_c_Routing = "https://onerecord.iata.org/ns/cargo/Routing";
        //public final static IRI c_Routing = IRI.create(s_c_Routing);
        /**
         * Scheduling details
         * 
         */
        public const string s_c_Schedule = "https://onerecord.iata.org/ns/cargo/Schedule";
        //public final static IRI c_Schedule = IRI.create(s_c_Schedule);
        /**
         * Scheduled Legs class to be used to identify legs. Can be used with Booking Option Request as an indicator of preferred Routing or with Booking Option when a carrier proposes a specific Routing.
         * 
         */
        public const string s_c_ScheduledLegs = "https://onerecord.iata.org/ns/cargo/ScheduledLegs";
        //public final static IRI c_ScheduledLegs = IRI.create(s_c_ScheduledLegs);
        /**
         * Security declaration details
         * 
         */
        public const string s_c_SecurityDeclaration = "https://onerecord.iata.org/ns/cargo/SecurityDeclaration";
        //public final static IRI c_SecurityDeclaration = IRI.create(s_c_SecurityDeclaration);
        /**
         * Sensor details and measurements, linked to Connected Devices
         * 
         */
        public const string s_c_Sensor = "https://onerecord.iata.org/ns/cargo/Sensor";
        //public final static IRI c_Sensor = IRI.create(s_c_Sensor);
        /**
         * Sensor measurements details for Geolocation sensors (sensorType = "Geolocation")
         * 
         */
        public const string s_c_SensorGeoloc = "https://onerecord.iata.org/ns/cargo/SensorGeoloc";
        //public final static IRI c_SensorGeoloc = IRI.create(s_c_SensorGeoloc);
        /**
         * Sensor measurements details for sensors other than Geolocation sensors (sensorType != "Geolocation")
         * 
         */
        public const string s_c_SensorOther = "https://onerecord.iata.org/ns/cargo/SensorOther";
        //public final static IRI c_SensorOther = IRI.create(s_c_SensorOther);
        /**
         * Service request details
         * 
         */
        public const string s_c_ServiceRequest = "https://onerecord.iata.org/ns/cargo/ServiceRequest";
        //public final static IRI c_ServiceRequest = IRI.create(s_c_ServiceRequest);
        /**
         * Shipment details
         * 
         */
        public const string s_c_Shipment = "https://onerecord.iata.org/ns/cargo/Shipment";
        //public final static IRI c_Shipment = IRI.create(s_c_Shipment);
        /**
         * Special handling details
         * 
         */
        public const string s_c_SpecialHandling = "https://onerecord.iata.org/ns/cargo/SpecialHandling";
        //public final static IRI c_SpecialHandling = IRI.create(s_c_SpecialHandling);
        /**
         * Transport means details
         * 
         */
        public const string s_c_TransportMeans = "https://onerecord.iata.org/ns/cargo/TransportMeans";
        //public final static IRI c_TransportMeans = IRI.create(s_c_TransportMeans);
        /**
         * Transport movement details, replaces the TransportSegment in v1.1 and above
         * 
         */
        public const string s_c_TransportMovement = "https://onerecord.iata.org/ns/cargo";
        //public final static IRI c_TransportMovement = IRI.create(s_c_TransportMovement);
        /**
         * Transport segment details
         * 
         */
        public const string s_c_TransportSegment = "https://onerecord.iata.org/ns/cargo/TransportSegment";
        //public final static IRI c_TransportSegment = IRI.create(s_c_TransportSegment);
        /**
         * Unit Load Device details
         * 
         */
        public const string s_c_ULD = "https://onerecord.iata.org/ns/cargo/ULD";
        //public final static IRI c_ULD = IRI.create(s_c_ULD);
        /**
         * Volumetric weight details
         * 
         */
        public const string s_c_Value = "https://onerecord.iata.org/ns/cargo/Value";
        //public final static IRI c_Value = IRI.create(s_c_Value);
        /**
         * Unit of measurement details
         * 
         */
        public const string s_c_VolumetricWeight = "https://onerecord.iata.org/ns/cargo/VolumetricWeight";
        //public final static IRI c_VolumetricWeight = IRI.create(s_c_VolumetricWeight);
        /**
         * Waybill details
         * 
         */
        public const string s_c_Waybill = "https://onerecord.iata.org/ns/cargo#Waybill";
        //public final static IRI c_Waybill = IRI.create(s_c_Waybill);
        public const string s_p_topObjectProperty = "http://www.w3.org/2002/07/owl#topObjectProperty";
        //public final static IRI p_topObjectProperty = IRI.create(s_p_topObjectProperty);
        /**
         * Country details
         * 
         */
        public const string s_p_country = "https://onerecord.iata.org/ns/cargo/Address#country";
        //public final static IRI p_country = IRI.create(s_p_country);
        /**
         * Carrier details
         * 
         */
        public const string s_p_carrier = "https://onerecord.iata.org/ns/cargo#carrier";
        //public final static IRI p_carrier = IRI.create(s_p_carrier);
        /**
         * Reference to the Carrier products included in the offer
         * 
         */
        public const string s_p_carrierProductInfo = "https://onerecord.iata.org/ns/cargo#carrierProductInfo";
        //public final static IRI p_carrierProductInfo = IRI.create(s_p_carrierProductInfo);
        /**
         * Consignee details
         * 
         */
        public const string s_p_consignee = "https://onerecord.iata.org/ns/cargo#consignee";
        //public final static IRI p_consignee = IRI.create(s_p_consignee);
        /**
         * Freight Forwarder details
         * 
         */
        public const string s_p_freightForwarder = "https://onerecord.iata.org/ns/cargo#freightForwarder";
        //public final static IRI p_freightForwarder = IRI.create(s_p_freightForwarder);
        /**
         * Other parties to be notified of the booking evolution
         * 
         */
        public const string s_p_notifyParty = "https://onerecord.iata.org/ns/cargo#notifyParty";
        //public final static IRI p_notifyParty = IRI.create(s_p_notifyParty);
        /**
         * Price of the Booking (if different from the offer)
         * 
         */
        public const string s_p_price = "https://onerecord.iata.org/ns/cargo#price";
        //public final static IRI p_price = IRI.create(s_p_price);
        /**
         * Reference to the Request
         * 
         */
        public const string s_p_requestRef = "https://onerecord.iata.org/ns/cargo#requestRef";
        //public final static IRI p_requestRef = IRI.create(s_p_requestRef);
        /**
         * Routing details of the offer, to be compared with routing preferences of the quote request
         * 
         */
        public const string s_p_routing = "https://onerecord.iata.org/ns/cargo#routing";
        //public final static IRI p_routing = IRI.create(s_p_routing);
        /**
         * Details of the shipement that is to be shipped
         * 
         */
        public const string s_p_shipmentDetails = "https://onerecord.iata.org/ns/cargo#shipmentDetails";
        //public final static IRI p_shipmentDetails = IRI.create(s_p_shipmentDetails);
        /**
         * Shipper information
         * 
         */
        public const string s_p_shipper = "https://onerecord.iata.org/ns/cargo#shipper";
        //public final static IRI p_shipper = IRI.create(s_p_shipper);
        /**
         * Transport segment linked to the offer, including the Departure and Arrival locations
         * 
         */
        public const string s_p_transportMovement = "https://onerecord.iata.org/ns/cargo#transportMovement";
        //public final static IRI p_transportMovement = IRI.create(s_p_transportMovement);
        /**
         * House or Master Waybill unique identifier
         * 
         */
        public const string s_p_waybillNumber = "https://onerecord.iata.org/ns/cargo#waybillNumber";
        //public final static IRI p_waybillNumber = IRI.create(s_p_waybillNumber);
        /**
         * Booking Segment of the Booking Option
         * 
         */
        public const string s_p_bookingSegment = "https://onerecord.iata.org/ns/cargo#bookingSegment";
        //public final static IRI p_bookingSegment = IRI.create(s_p_bookingSegment);
        /**
         * booking times details of the Booking Option (proposed or actual)
         * 
         */
        public const string s_p_bookingTimes = "https://onerecord.iata.org/ns/cargo#bookingTimes";
        //public final static IRI p_bookingTimes = IRI.create(s_p_bookingTimes);
        /**
         * Carrier details
         * 
         */
        public const string s_p_carrier_A = "https://onerecord.iata.org/ns/cargo#carrier";
        //public final static IRI p_carrier_A = IRI.create(s_p_carrier_A);
        /**
         * Reference to the Carrier products included in the offer
         * 
         */
        public const string s_p_carrierProductInfo_A = "https://onerecord.iata.org/ns/cargo#carrierProductInfo";
        //public final static IRI p_carrierProductInfo_A = IRI.create(s_p_carrierProductInfo_A);
        /**
         * Consignee details
         * 
         */
        public const string s_p_consignee_A = "https://onerecord.iata.org/ns/cargo#consignee";
        //public final static IRI p_consignee_A = IRI.create(s_p_consignee_A);
        /**
         * Freight forwarder details
         * 
         */
        public const string s_p_freightForwarder_A = "https://onerecord.iata.org/ns/cargo#freightForwarder";
        //public final static IRI p_freightForwarder_A = IRI.create(s_p_freightForwarder_A);
        /**
         * Other parties to be notified of the booking evolution
         * 
         */
        public const string s_p_notifyParty_A = "https://onerecord.iata.org/ns/cargo#notifyParty";
        //public final static IRI p_notifyParty_A = IRI.create(s_p_notifyParty_A);
        /**
         * Parties involved in the Booking Option (e.g. shipper, forwarder, ...)
         * 
         */
        public const string s_p_parties = "https://onerecord.iata.org/ns/cargo#parties";
        //public final static IRI p_parties = IRI.create(s_p_parties);
        /**
         * Price of the Booking (if different from the offer)
         * 
         */
        public const string s_p_price_A = "https://onerecord.iata.org/ns/cargo#price";
        //public final static IRI p_price_A = IRI.create(s_p_price_A);
        /**
         * Reference to the Booking option request
         * 
         */
        public const string s_p_requestRef_A = "https://onerecord.iata.org/ns/cargo#requestRef";
        //public final static IRI p_requestRef_A = IRI.create(s_p_requestRef_A);
        /**
         * Routing details of the offer, to be compared with routing preferences of the quote request
         * 
         */
        public const string s_p_routing_A = "https://onerecord.iata.org/ns/cargo#routing";
        //public final static IRI p_routing_A = IRI.create(s_p_routing_A);
        /**
         * Schedule details of the Booking Option (proposed or actual)
         * 
         */
        public const string s_p_schedule = "https://onerecord.iata.org/ns/cargo#schedule";
        //public final static IRI p_schedule = IRI.create(s_p_schedule);
        /**
         * Details of the shipement that is to be shipped
         * 
         */
        public const string s_p_shipmentDetails_A = "https://onerecord.iata.org/ns/cargo#shipmentDetails";
        //public final static IRI p_shipmentDetails_A = IRI.create(s_p_shipmentDetails_A);
        /**
         * Shipper details
         * 
         */
        public const string s_p_shipper_A = "https://onerecord.iata.org/ns/cargo#shipper";
        //public final static IRI p_shipper_A = IRI.create(s_p_shipper_A);
        /**
         * Transport segment linked to the offer, including the Departure and Arrival locations
         * 
         */
        public const string s_p_transportMovement_A = "https://onerecord.iata.org/ns/cargo#transportMovement";
        //public final static IRI p_transportMovement_A = IRI.create(s_p_transportMovement_A);
        /**
         * House or Master Waybill unique identifier
         * 
         */
        public const string s_p_waybillNumber_A = "https://onerecord.iata.org/ns/cargo#waybillNumber";
        //public final static IRI p_waybillNumber_A = IRI.create(s_p_waybillNumber_A);
        /**
         * The Booking Segment linked to the Booking Optio Request
         * 
         */
        public const string s_p_bookingSegment_A = "https://onerecord.iata.org/ns/cargo#bookingSegment";
        //public final static IRI p_bookingSegment_A = IRI.create(s_p_bookingSegment_A);
        /**
         * Parties involved if known
         * 
         */
        public const string s_p_parties_A = "https://onerecord.iata.org/ns/cargo#parties";
        //public final static IRI p_parties_A = IRI.create(s_p_parties_A);
        /**
         * Ratings preferences of the request
         * 
         */
        public const string s_p_ratingsPreference = "https://onerecord.iata.org/ns/cargo#ratingsPreference";
        //public final static IRI p_ratingsPreference = IRI.create(s_p_ratingsPreference);
        /**
         * Routing details that are part of the request, these details will be used to determine if the offer is a perfect match
         * 
         */
        public const string s_p_routingPreferences = "https://onerecord.iata.org/ns/cargo#routingPreferences";
        //public final static IRI p_routingPreferences = IRI.create(s_p_routingPreferences);
        /**
         * Schedule preferences of the request
         * 
         */
        public const string s_p_schedulePreferences = "https://onerecord.iata.org/ns/cargo#schedulePreferences";
        //public final static IRI p_schedulePreferences = IRI.create(s_p_schedulePreferences);
        /**
         * Details of the shipement that is to be shipped
         * 
         */
        public const string s_p_shipmentDetails_A_A = "https://onerecord.iata.org/ns/cargo#shipmentDetails";
        //public final static IRI p_shipmentDetails_A_A = IRI.create(s_p_shipmentDetails_A_A);
        /**
         * Schedule preferences of the request
         * 
         */
        public const string s_p_timePreferences = "https://onerecord.iata.org/ns/cargo#timePreferences";
        //public final static IRI p_timePreferences = IRI.create(s_p_timePreferences);
        /**
         * Transport segment linked to the request, including the Departure and Arrival locations requested
         * 
         */
        public const string s_p_transportMovement_A_A = "https://onerecord.iata.org/ns/cargo#transportMovement";
        //public final static IRI p_transportMovement_A_A = IRI.create(s_p_transportMovement_A_A);
        /**
         * Unit preferences of the request (e.g. kg or cm)
         * 
         */
        public const string s_p_unitsPreference = "https://onerecord.iata.org/ns/cargo#unitsPreference";
        //public final static IRI p_unitsPreference = IRI.create(s_p_unitsPreference);
        /**
         * The arrival location of the Booking Segment
         * 
         */
        public const string s_p_arrivalLocation = "https://onerecord.iata.org/ns/cargo/Segment#arrivalLocation";
        //public final static IRI p_arrivalLocation = IRI.create(s_p_arrivalLocation);
        /**
         * The Booking Option linked to the Booking Segment
         * 
         */
        public const string s_p_bookingOptions = "https://onerecord.iata.org/ns/cargo/Segment#bookingOptions";
        //public final static IRI p_bookingOptions = IRI.create(s_p_bookingOptions);
        /**
         * The departure location of the Booking Segment
         * 
         */
        public const string s_p_departureLocation = "https://onerecord.iata.org/ns/cargo/Segment#departureLocation";
        //public final static IRI p_departureLocation = IRI.create(s_p_departureLocation);
        /**
         * The BookingOptionRequest linked to the Booking Segment
         * 
         */
        public const string s_p_requests = "https://onerecord.iata.org/ns/cargo/Segment#requests";
        //public final static IRI p_requests = IRI.create(s_p_requests);
        /**
         * Reference to the BookingOption where the booking times are used
         * 
         */
        public const string s_p_bookingOption = "https://onerecord.iata.org/ns/cargo/Times#bookingOption";
        //public final static IRI p_bookingOption = IRI.create(s_p_bookingOption);
        /**
         * Reference to the BookingOptionRequest where the booking times are used
         * 
         */
        public const string s_p_bookingOptionRequest = "https://onerecord.iata.org/ns/cargo/Times#bookingOptionRequest";
        //public final static IRI p_bookingOptionRequest = IRI.create(s_p_bookingOptionRequest);
        /**
         * Refers to the mother company of the branch
         * 
         */
        public const string s_p_company = "https://onerecord.iata.org/ns/cargo/Branch#company";
        //public final static IRI p_company = IRI.create(s_p_company);
        /**
         * Contact person details
         * 
         */
        public const string s_p_contactPerson = "https://onerecord.iata.org/ns/cargo/Branch#contactPerson";
        //public final static IRI p_contactPerson = IRI.create(s_p_contactPerson);
        /**
         * Location and address details
         * 
         */
        public const string s_p_location = "https://onerecord.iata.org/ns/cargo/Branch#location";
        //public final static IRI p_location = IRI.create(s_p_location);
        /**
         * Other identifiers (e.g. LEI (Legal Entity Identifier), TIN (Trader Identification Number), PIMA address, Account number, VAT/Tax id, Legal Registration id, DUNS number, etc)
         * 
         */
        public const string s_p_otherIdentifier = "https://onerecord.iata.org/ns/cargo/Branch#otherIdentifier";
        //public final static IRI p_otherIdentifier = IRI.create(s_p_otherIdentifier);
        /**
         * CO2 emissions calculated
         * 
         */
        public const string s_p_calculatedEmissions = "https://onerecord.iata.org/ns/cargo/CO2Emissions#calculatedEmissions";
        //public final static IRI p_calculatedEmissions = IRI.create(s_p_calculatedEmissions);
        /**
         * Transport Movement linked to the CO2 Emissions object
         * 
         */
        public const string s_p_transportMovement_A_A_A = "https://onerecord.iata.org/ns/cargo/CO2Emissions#transportMovement";
        //public final static IRI p_transportMovement_A_A_A = IRI.create(s_p_transportMovement_A_A_A);
        /**
         * Reference to the BookingOption where the carrier product is used
         * 
         */
        public const string s_p_bookingOption_A = "https://onerecord.iata.org/ns/cargo/CarrierProduct#bookingOption";
        //public final static IRI p_bookingOption_A = IRI.create(s_p_bookingOption_A);
        /**
         * Reference to the product
         * 
         */
        public const string s_p_product = "https://onerecord.iata.org/ns/cargo/Characteristics#product";
        //public final static IRI p_product = IRI.create(s_p_product);
        /**
         * Company branches
         * 
         */
        public const string s_p_branch = "https://onerecord.iata.org/ns/cargo/Company#branch";
        //public final static IRI p_branch = IRI.create(s_p_branch);
        /**
         * Refers to the mother company of the branch
         * 
         */
        public const string s_p_company_A = "https://onerecord.iata.org/ns/cargo#company";
        //public final static IRI p_company_A = IRI.create(s_p_company_A);
        /**
         * Contact person details
         * 
         */
        public const string s_p_contactPersons = "https://onerecord.iata.org/ns/cargo#contactPersons";
        //public final static IRI p_contactPersons = IRI.create(s_p_contactPersons);
        /**
         * Location and address details
         * 
         */
        public const string s_p_location_A = "https://onerecord.iata.org/ns/cargo#location";
        //public final static IRI p_location_A = IRI.create(s_p_location_A);
        /**
         * Other identifiers (e.g. LEI (Legal Entity Identifier), TIN (Trader Identification Number), PIMA address, Account number, VAT/Tax id, Legal Registration id, DUNS number, etc)
         * 
         */
        public const string s_p_otherIdentifiers = "https://onerecord.iata.org/ns/cargo#otherIdentifiers";
        //public final static IRI p_otherIdentifiers = IRI.create(s_p_otherIdentifiers);
        /**
         * Other contact options e.g. Skype, Whatsapp, Viber, Fax etc
         * 
         */
        public const string s_p_other = "https://onerecord.iata.org/ns/cargo/Contact#other";
        //public final static IRI p_other = IRI.create(s_p_other);
        /**
         * Piece on which the Customs Info is applicable
         * 
         */
        public const string s_p_piece = "https://onerecord.iata.org/ns/cargo/CustomsInfo#piece";
        //public final static IRI p_piece = IRI.create(s_p_piece);
        /**
         * DgRadioactiveIsotope.
         * 
         */
        public const string s_p_isotopes = "https://onerecord.iata.org/ns/cargo/DgProductRadioactive#isotopes";
        //public final static IRI p_isotopes = IRI.create(s_p_isotopes);
        /**
         * Height
         * 
         */
        public const string s_p_height = "https://onerecord.iata.org/ns/cargo/Dimensions#height";
        //public final static IRI p_height = IRI.create(s_p_height);
        /**
         * Length
         * 
         */
        public const string s_p_length = "https://onerecord.iata.org/ns/cargo/Dimensions#length";
        //public final static IRI p_length = IRI.create(s_p_length);
        /**
         * Volume
         * 
         */
        public const string s_p_volume = "https://onerecord.iata.org/ns/cargo/Dimensions#volume";
        //public final static IRI p_volume = IRI.create(s_p_volume);
        /**
         * Width
         * 
         */
        public const string s_p_width = "https://onerecord.iata.org/ns/cargo/Dimensions#width";
        //public final static IRI p_width = IRI.create(s_p_width);
        /**
         * Reference to te pieces (Live Animals) of the permit
         * 
         */
        public const string s_p_consignmentItems = "https://onerecord.iata.org/ns/cargo/EpermitConsignment#consignmentItems";
        //public final static IRI p_consignmentItems = IRI.create(s_p_consignmentItems);
        /**
         * Quatity measured by the examining authority (box 14)
         * 
         */
        public const string s_p_examiningQuantity = "https://onerecord.iata.org/ns/cargo/EpermitConsignment#examiningQuantity";
        //public final static IRI p_examiningQuantity = IRI.create(s_p_examiningQuantity);
        /**
         * Signatory company name
         * 
         */
        public const string s_p_signatoryCompany = "https://onerecord.iata.org/ns/cargo/EpermitSignature#signatoryCompany";
        //public final static IRI p_signatoryCompany = IRI.create(s_p_signatoryCompany);
        /**
         * Refers to the URI of the linked object(s)
         * 
         */
        public const string s_p_linkedObject = "https://onerecord.iata.org/ns/cargo/Event#linkedObject";
        //public final static IRI p_linkedObject = IRI.create(s_p_linkedObject);
        /**
         * Location of event
         * 
         */
        public const string s_p_location_A_A = "https://onerecord.iata.org/ns/cargo/Event#location";
        //public final static IRI p_location_A_A = IRI.create(s_p_location_A_A);
        /**
         * Party performing the event
         * 
         */
        public const string s_p_performedBy = "https://onerecord.iata.org/ns/cargo/Event#performedBy";
        //public final static IRI p_performedBy = IRI.create(s_p_performedBy);
        public const string s_p_performedByPerson = "https://onerecord.iata.org/ns/cargo/Event#performedByPerson";
        //public final static IRI p_performedByPerson = IRI.create(s_p_performedByPerson);
        /**
         * Document originator details and contacts
         * 
         */
        public const string s_p_documentOriginator = "https://onerecord.iata.org/ns/cargo/ExternalReference#documentOriginator";
        //public final static IRI p_documentOriginator = IRI.create(s_p_documentOriginator);
        /**
         * Location of the document, e.g. location where the document was emitted
         * 
         */
        public const string s_p_location_A_A_A = "https://onerecord.iata.org/ns/cargo/ExternalReference#location";
        //public final static IRI p_location_A_A_A = IRI.create(s_p_location_A_A_A);
        /**
         * Elevation from sea level - Change of data type to Value as of ontology v1.1
         * 
         */
        public const string s_p_elevation = "https://onerecord.iata.org/ns/cargo/Geolocation#elevation";
        //public final static IRI p_elevation = IRI.create(s_p_elevation);
        /**
         * Refers to the person that requests the handling/service
         * 
         */
        public const string s_p_requestedBy = "https://onerecord.iata.org/ns/cargo/HandlingInstructions#requestedBy";
        //public final static IRI p_requestedBy = IRI.create(s_p_requestedBy);
        /**
         * Party covering the insurance 
         * 
         */
        public const string s_p_coveringParty = "https://onerecord.iata.org/ns/cargo/Insurance#coveringParty";
        //public final static IRI p_coveringParty = IRI.create(s_p_coveringParty);
        /**
         * Insured amount - amount covered by the insurance policy
         * 
         */
        public const string s_p_insuranceAmount = "https://onerecord.iata.org/ns/cargo/Insurance#insuranceAmount";
        //public final static IRI p_insuranceAmount = IRI.create(s_p_insuranceAmount);
        /**
         * Reference to the shipment insured
         * 
         */
        public const string s_p_insuranceShipment = "https://onerecord.iata.org/ns/cargo/Insurance#insuranceShipment";
        //public final static IRI p_insuranceShipment = IRI.create(s_p_insuranceShipment);
        /**
         * Manufacturer of the device
         * 
         */
        public const string s_p_deviceManufacturer = "https://onerecord.iata.org/ns/cargo/IotDevice#deviceManufacturer";
        //public final static IRI p_deviceManufacturer = IRI.create(s_p_deviceManufacturer);
        /**
         * Reference to the sensors linked to the device
         * 
         */
        public const string s_p_sensors = "https://onerecord.iata.org/ns/cargo/IotDevice#sensors";
        //public final static IRI p_sensors = IRI.create(s_p_sensors);
        /**
         * Dimensions of the item
         * 
         */
        public const string s_p_dimensions = "https://onerecord.iata.org/ns/cargo/Item#dimensions";
        //public final static IRI p_dimensions = IRI.create(s_p_dimensions);
        /**
         * URI of the PIECE that contains the Item
         * 
         */
        public const string s_p_isInPiece = "https://onerecord.iata.org/ns/cargo/Item#isInPiece";
        //public final static IRI p_isInPiece = IRI.create(s_p_isInPiece);
        /**
         * Other identifier details
         * 
         */
        public const string s_p_otherIdentifiers_A = "https://onerecord.iata.org/ns/cargo/Item#otherIdentifiers";
        //public final static IRI p_otherIdentifiers_A = IRI.create(s_p_otherIdentifiers_A);
        /**
         * URI of the product
         * 
         */
        public const string s_p_product_A = "https://onerecord.iata.org/ns/cargo/Item#product";
        //public final static IRI p_product_A = IRI.create(s_p_product_A);
        /**
         * Production country details
         * 
         */
        public const string s_p_productionCountry = "https://onerecord.iata.org/ns/cargo/Item#productionCountry";
        //public final static IRI p_productionCountry = IRI.create(s_p_productionCountry);
        /**
         * Quantity of the item when applicable, witth associated units of measure
         * 
         */
        public const string s_p_quantity = "https://onerecord.iata.org/ns/cargo/Item#quantity";
        //public final static IRI p_quantity = IRI.create(s_p_quantity);
        /**
         * Item target country
         * 
         */
        public const string s_p_targetCountry = "https://onerecord.iata.org/ns/cargo/Item#targetCountry";
        //public final static IRI p_targetCountry = IRI.create(s_p_targetCountry);
        /**
         * Product price per unit in the base
         * 
         */
        public const string s_p_unitPrice = "https://onerecord.iata.org/ns/cargo/Item#unitPrice";
        //public final static IRI p_unitPrice = IRI.create(s_p_unitPrice);
        /**
         * Weight of the item
         * 
         */
        public const string s_p_weight = "https://onerecord.iata.org/ns/cargo/Item#weight";
        //public final static IRI p_weight = IRI.create(s_p_weight);
        /**
         * Contains the Emergency contact name (e.g. the name of the agency) and phone number (min required)
         * 
         */
        public const string s_p_emergencyContact = "https://onerecord.iata.org/ns/cargo/ItemDg#emergencyContact";
        //public final static IRI p_emergencyContact = IRI.create(s_p_emergencyContact);
        /**
         * The total net weight of dangerous goods transported of this line item. For air transport the value must be the volume or mass in each package.
         * 
         */
        public const string s_p_netWeightMeasure = "https://onerecord.iata.org/ns/cargo/ItemDg#netWeightMeasure";
        //public final static IRI p_netWeightMeasure = IRI.create(s_p_netWeightMeasure);
        /**
         * Consignee company details, including complete name and address (box 3)
         * 
         */
        public const string s_p_consignee_A_A = "https://onerecord.iata.org/ns/cargo/LiveAnimalsEpermit#consignee";
        //public final static IRI p_consignee_A_A = IRI.create(s_p_consignee_A_A);
        /**
         * Reference to the pieces and properties linked to the Permit (box 7 to 12)
         * 
         */
        public const string s_p_consignments = "https://onerecord.iata.org/ns/cargo/LiveAnimalsEpermit#consignments";
        //public final static IRI p_consignments = IRI.create(s_p_consignments);
        /**
         * List of all the signatures of the Epermit (applicant box 4, issuing authority box 6, issuer box 13 and examining authority box 14)
         * 
         */
        public const string s_p_signatures = "https://onerecord.iata.org/ns/cargo/LiveAnimalsEpermit#signatures";
        //public final static IRI p_signatures = IRI.create(s_p_signatures);
        /**
         * Address details
         * 
         */
        public const string s_p_address = "https://onerecord.iata.org/ns/cargo/Location#address";
        //public final static IRI p_address = IRI.create(s_p_address);
        /**
         * Geolocation details
         * 
         */
        public const string s_p_geolocation = "https://onerecord.iata.org/ns/cargo/Location#geolocation";
        //public final static IRI p_geolocation = IRI.create(s_p_geolocation);
        /**
         * Events object
         * 
         */
        public const string s_p_events = "https://onerecord.iata.org/ns/cargo/LogisticsObject#events";
        //public final static IRI p_events = IRI.create(s_p_events);
        /**
         * Allows to link Logistic Objects with IoT Devices
         * 
         */
        public const string s_p_iotDevices = "https://onerecord.iata.org/ns/cargo/LogisticsObject#iotDevices";
        //public final static IRI p_iotDevices = IRI.create(s_p_iotDevices);
        /**
         * Geolocation measurements details
         * 
         */
        public const string s_p_geolocationMeasurement = "https://onerecord.iata.org/ns/cargo/MeasurementsGeoloc#geolocationMeasurement";
        //public final static IRI p_geolocationMeasurement = IRI.create(s_p_geolocationMeasurement);
        /**
         * Value for measurements other than Geolocation, includes value and unit of measure as described in the Interactive cargo/ RP
         * 
         */
        public const string s_p_genericMeasurement = "https://onerecord.iata.org/ns/cargo/MeasurementsOther#genericMeasurement";
        //public final static IRI p_genericMeasurement = IRI.create(s_p_genericMeasurement);
        /**
         * Company details
         * 
         */
        public const string s_p_companyDetails = "https://onerecord.iata.org/ns/cargo/OtherParty#companyDetails";
        //public final static IRI p_companyDetails = IRI.create(s_p_companyDetails);
        /**
         * Piece on which the Packaging type is applicable
         * 
         */
        public const string s_p_piece_A = "https://onerecord.iata.org/ns/cargo/PackagingType#piece";
        //public final static IRI p_piece_A = IRI.create(s_p_piece_A);
        /**
         * Reference to other identifiers for parties. In the context of the AWB, otherIdentifier object can be used with types "PrimaryID" (internal ID), "Additional ID" (Standard ID) or "AccountID" (Account numbers).
         * 
         */
        public const string s_p_otherIdentifiers_A_A = "https://onerecord.iata.org/ns/cargo/Party#otherIdentifiers";
        //public final static IRI p_otherIdentifiers_A_A = IRI.create(s_p_otherIdentifiers_A_A);
        /**
         * Reference to the Company
         * 
         */
        public const string s_p_partyDetails = "https://onerecord.iata.org/ns/cargo/Party#partyDetails";
        //public final static IRI p_partyDetails = IRI.create(s_p_partyDetails);
        /**
         * Refers to the Branch the person is associated with
         * 
         */
        public const string s_p_associatedBranch = "https://onerecord.iata.org/ns/cargo/Person#associatedBranch";
        //public final static IRI p_associatedBranch = IRI.create(s_p_associatedBranch);
        /**
         * Contact details
         * 
         */
        public const string s_p_contact = "https://onerecord.iata.org/ns/cargo/Person#contact";
        //public final static IRI p_contact = IRI.create(s_p_contact);
        /**
         * Linked documents to the person, e.g. driver's license, ID, etc.
         * 
         */
        public const string s_p_documents = "https://onerecord.iata.org/ns/cargo/Person#documents";
        //public final static IRI p_documents = IRI.create(s_p_documents);
        /**
         * Reference to the item(s) contained in the piece
         * 
         */
        public const string s_p_containedItems = "https://onerecord.iata.org/ns/cargo#containedItems";
        //public final static IRI p_containedItems = IRI.create(s_p_containedItems);
        /**
         * Details of contained piece(s)
         * 
         */
        public const string s_p_containedPieces = "https://onerecord.iata.org/ns/cargo#containedPieces";
        //public final static IRI p_containedPieces = IRI.create(s_p_containedPieces);
        /**
         * Customs details
         * 
         */
        public const string s_p_customsInfo = "https://onerecord.iata.org/ns/cargo#customsInfo";
        //public final static IRI p_customsInfo = IRI.create(s_p_customsInfo);
        /**
         * Dimensions details
         * 
         */
        public const string s_p_dimensions_A = "https://onerecord.iata.org/ns/cargo#dimensions";
        //public final static IRI p_dimensions_A = IRI.create(s_p_dimensions_A);
        /**
         * Reference documents details
         * 
         */
        public const string s_p_externalReferences = "https://onerecord.iata.org/ns/cargo#externalReferences";
        //public final static IRI p_externalReferences = IRI.create(s_p_externalReferences);
        /**
         * Weight details
         * 
         */
        public const string s_p_grossWeight = "https://onerecord.iata.org/ns/cargo#grossWeight";
        //public final static IRI p_grossWeight = IRI.create(s_p_grossWeight);
        /**
         * Links to Handling instructions / service requests of the piece
         * 
         */
        public const string s_p_handlingInstructions = "https://onerecord.iata.org/ns/cargo#handlingInstructions";
        //public final static IRI p_handlingInstructions = IRI.create(s_p_handlingInstructions);
        /**
         * Other piece identification ( e.g. Shipping Marks, Seal)
         * 
         */
        public const string s_p_otherIdentifiers_A_A_A = "https://onerecord.iata.org/ns/cargo#otherIdentifiers";
        //public final static IRI p_otherIdentifiers_A_A_A = IRI.create(s_p_otherIdentifiers_A_A_A);
        /**
         * Other party company details - e.g. the party to be notified
         * 
         */
        public const string s_p_otherParty = "https://onerecord.iata.org/ns/cargo#otherParty";
        //public final static IRI p_otherParty = IRI.create(s_p_otherParty);
        /**
         * Packaging details 
         * 
         */
        public const string s_p_packagingType = "https://onerecord.iata.org/ns/cargo#packagingType";
        //public final static IRI p_packagingType = IRI.create(s_p_packagingType);
        /**
         * Other party company details - e.g. the party to be notified
         * 
         */
        public const string s_p_parties_A_A = "https://onerecord.iata.org/ns/cargo#parties";
        //public final static IRI p_parties_A_A = IRI.create(s_p_parties_A_A);
        /**
         * Product of the piece, mandatory when there are no items
         * 
         */
        public const string s_p_product_A_A = "https://onerecord.iata.org/ns/cargo#product";
        //public final static IRI p_product_A_A = IRI.create(s_p_product_A_A);
        /**
         * Goods production country, mandatory when there are no Items
         * 
         */
        public const string s_p_productionCountry_A = "https://onerecord.iata.org/ns/cargo#productionCountry";
        //public final static IRI p_productionCountry_A = IRI.create(s_p_productionCountry_A);
        /**
         * Security details of the piece
         * 
         */
        public const string s_p_securityDeclaration = "https://onerecord.iata.org/ns/cargo#securityDeclaration";
        //public final static IRI p_securityDeclaration = IRI.create(s_p_securityDeclaration);
        /**
         * Security details
         * 
         */
        public const string s_p_securityStatus = "https://onerecord.iata.org/ns/cargo#securityStatus";
        //public final static IRI p_securityStatus = IRI.create(s_p_securityStatus);
        /**
         * Security requests
         * 
         */
        public const string s_p_serviceRequest = "https://onerecord.iata.org/ns/cargo#serviceRequest";
        //public final static IRI p_serviceRequest = IRI.create(s_p_serviceRequest);
        /**
         * Shipment on which the piece is assigned to
         * 
         */
        public const string s_p_shipment = "https://onerecord.iata.org/ns/cargo#shipment";
        //public final static IRI p_shipment = IRI.create(s_p_shipment);
        /**
         * Shipper company details - e.g. the party shipping the piece
         * 
         */
        public const string s_p_shipper_A_A = "https://onerecord.iata.org/ns/cargo#shipper";
        //public final static IRI p_shipper_A_A = IRI.create(s_p_shipper_A_A);
        /**
         * Special Handling details
         * 
         */
        public const string s_p_specialHandling = "https://onerecord.iata.org/ns/cargo#specialHandling";
        //public final static IRI p_specialHandling = IRI.create(s_p_specialHandling);
        /**
         * Transport Movements on which the piece is transported
         * 
         */
        public const string s_p_transportMovements = "https://onerecord.iata.org/ns/cargo#transportMovements";
        //public final static IRI p_transportMovements = IRI.create(s_p_transportMovements);
        /**
         * Segment related to the transport status
         * 
         */
        public const string s_p_transportSegments = "https://onerecord.iata.org/ns/cargo#transportSegments";
        //public final static IRI p_transportSegments = IRI.create(s_p_transportSegments);
        /**
         * ULD on which the (virtual) piece has been loaded into - URIs of the ULD
         * 
         */
        public const string s_p_uldReference = "https://onerecord.iata.org/ns/cargo#uldReference";
        //public final static IRI p_uldReference = IRI.create(s_p_uldReference);
        /**
         * Volumetric weight details
         * 
         */
        public const string s_p_volumetricWeight = "https://onerecord.iata.org/ns/cargo#volumetricWeight";
        //public final static IRI p_volumetricWeight = IRI.create(s_p_volumetricWeight);
        /**
         * Reference to the Dangerous Goods declaration
         * 
         */
        public const string s_p_dgDeclaration = "https://onerecord.iata.org/ns/cargoDg#dgDeclaration";
        //public final static IRI p_dgDeclaration = IRI.create(s_p_dgDeclaration);
        /**
         * Reference to the permits associated with the Live Animals
         * 
         */
        public const string s_p_associatedEpermit = "https://onerecord.iata.org/ns/cargoLiveAnimals#associatedEpermit";
        //public final static IRI p_associatedEpermit = IRI.create(s_p_associatedEpermit);
        /**
         * Country of last re-export (box 12a)
         * 
         */
        public const string s_p_exportTradeCountry = "https://onerecord.iata.org/ns/cargoLiveAnimals#exportTradeCountry";
        //public final static IRI p_exportTradeCountry = IRI.create(s_p_exportTradeCountry);
        /**
         * country of origin (box 12)
         * 
         */
        public const string s_p_originTradeCountry = "https://onerecord.iata.org/ns/cargoLiveAnimals#originTradeCountry";
        //public final static IRI p_originTradeCountry = IRI.create(s_p_originTradeCountry);
        /**
         * Reference to the Booking or Offer
         * 
         */
        public const string s_p_bookingOption_A_A = "https://onerecord.iata.org/ns/cargo/Price#bookingOption";
        //public final static IRI p_bookingOption_A_A = IRI.create(s_p_bookingOption_A_A);
        /**
         * Reference to the Booking or Offer
         * 
         */
        public const string s_p_bookingRef = "https://onerecord.iata.org/ns/cargo/Price#bookingRef";
        //public final static IRI p_bookingRef = IRI.create(s_p_bookingRef);
        /**
         * Rating used for pricing
         * 
         */
        public const string s_p_ratings = "https://onerecord.iata.org/ns/cargo/Price#ratings";
        //public final static IRI p_ratings = IRI.create(s_p_ratings);
        /**
         * Charateristics of the product
         * 
         */
        public const string s_p_characteristics = "https://onerecord.iata.org/ns/cargo/Product#characteristics";
        //public final static IRI p_characteristics = IRI.create(s_p_characteristics);
        /**
         * Reference to the Items in which the product can be found.
         * 
         */
        public const string s_p_isInItems = "https://onerecord.iata.org/ns/cargo/Product#isInItems";
        //public final static IRI p_isInItems = IRI.create(s_p_isInItems);
        /**
         * Reference to the pieces where the product can be found. This needs to be filled in case there is no Item
         * 
         */
        public const string s_p_isInPieces = "https://onerecord.iata.org/ns/cargo/Product#isInPieces";
        //public final static IRI p_isInPieces = IRI.create(s_p_isInPieces);
        /**
         * Manufacturing company details and contacts
         * 
         */
        public const string s_p_manufacturer = "https://onerecord.iata.org/ns/cargo/Product#manufacturer";
        //public final static IRI p_manufacturer = IRI.create(s_p_manufacturer);
        /**
         * Other product identifier (e.g. Bar code, UPC, EAN, Amazon)
         * 
         */
        public const string s_p_otherIdentifier_A = "https://onerecord.iata.org/ns/cargo/Product#otherIdentifier";
        //public final static IRI p_otherIdentifier_A = IRI.create(s_p_otherIdentifier_A);
        /**
         * Dg Radioactive Material
         * 
         */
        public const string s_p_dgRadioactiveMaterial = "https://onerecord.iata.org/ns/cargo/ProductDg#dgRadioactiveMaterial";
        //public final static IRI p_dgRadioactiveMaterial = IRI.create(s_p_dgRadioactiveMaterial);
        /**
         * Reference to the ranges
         * 
         */
        public const string s_p_ranges = "https://onerecord.iata.org/ns/cargo/Ratings#ranges";
        //public final static IRI p_ranges = IRI.create(s_p_ranges);
        /**
         * Branch/Company
         * 
         */
        public const string s_p_entity = "https://onerecord.iata.org/ns/cargo/RegulatedEntity#entity";
        //public final static IRI p_entity = IRI.create(s_p_entity);
        /**
         * Regulated entity identifier (e.g. Regulated Agent Identifier) is mandatory
         * 
         */
        public const string s_p_regulatedEntityIdentifier = "https://onerecord.iata.org/ns/cargo/RegulatedEntity#regulatedEntityIdentifier";
        //public final static IRI p_regulatedEntityIdentifier = IRI.create(s_p_regulatedEntityIdentifier);
        /**
         * Parties involved if known
         * 
         */
        public const string s_p_parties_A_A_A = "https://onerecord.iata.org/ns/cargo/Request#parties";
        //public final static IRI p_parties_A_A_A = IRI.create(s_p_parties_A_A_A);
        /**
         * Ratings preferences of the request
         * 
         */
        public const string s_p_ratingsPreference_A = "https://onerecord.iata.org/ns/cargo/Request#ratingsPreference";
        //public final static IRI p_ratingsPreference_A = IRI.create(s_p_ratingsPreference_A);
        /**
         * Details of the shipement that is to be shipped
         * 
         */
        public const string s_p_shipmentDetails_A_A_A = "https://onerecord.iata.org/ns/cargo/Request#shipmentDetails";
        //public final static IRI p_shipmentDetails_A_A_A = IRI.create(s_p_shipmentDetails_A_A_A);
        /**
         * Transport segment linked to the request, including the Departure and Arrival locations requested
         * 
         */
        public const string s_p_transportMovement_A_A_A_A = "https://onerecord.iata.org/ns/cargo/Request#transportMovement";
        //public final static IRI p_transportMovement_A_A_A_A = IRI.create(s_p_transportMovement_A_A_A_A);
        /**
         * Unit preferences of the request (e.g. kg or cm)
         * 
         */
        public const string s_p_unitsPreference_A = "https://onerecord.iata.org/ns/cargo/Request#unitsPreference";
        //public final static IRI p_unitsPreference_A = IRI.create(s_p_unitsPreference_A);
        /**
         * Reference to the BookingOption where the Routing is used
         * 
         */
        public const string s_p_bookingOption_A_A_A = "https://onerecord.iata.org/ns/cargo/Routing#bookingOption";
        //public final static IRI p_bookingOption_A_A_A = IRI.create(s_p_bookingOption_A_A_A);
        /**
         * Scheduled Legs class to be used to identify legs. Can be used with Booking Option Request as an indicator of preferred Routing or with Booking Option when a carrier proposes a specific Routing.
         * 
         */
        public const string s_p_scheduledLegs = "https://onerecord.iata.org/ns/cargo/Routing#scheduledLegs";
        //public final static IRI p_scheduledLegs = IRI.create(s_p_scheduledLegs);
        /**
         * Arrival location of the leg
         * 
         */
        public const string s_p_arrivalLocation_A = "https://onerecord.iata.org/ns/cargo/ScheduledLegs#arrivalLocation";
        //public final static IRI p_arrivalLocation_A = IRI.create(s_p_arrivalLocation_A);
        /**
         * Departure Location of the leg
         * 
         */
        public const string s_p_departureLocation_A = "https://onerecord.iata.org/ns/cargo/ScheduledLegs#departureLocation";
        //public final static IRI p_departureLocation_A = IRI.create(s_p_departureLocation_A);
        /**
         * Name of person (or employee ID) who issued the security status
         * 
         */
        public const string s_p_issuedBy = "https://onerecord.iata.org/ns/cargo/SecurityDeclaration#issuedBy";
        //public final static IRI p_issuedBy = IRI.create(s_p_issuedBy);
        /**
         * Any other regulated entity that accepts custody of the cargo/ and accepts the security status originally issued
         * 
         */
        public const string s_p_otherRegulatedEntity = "https://onerecord.iata.org/ns/cargo/SecurityDeclaration#otherRegulatedEntity";
        //public final static IRI p_otherRegulatedEntity = IRI.create(s_p_otherRegulatedEntity);
        /**
         * Piece linked to the Security Declaration
         * 
         */
        public const string s_p_piece_A_A = "https://onerecord.iata.org/ns/cargo/SecurityDeclaration#piece";
        //public final static IRI p_piece_A_A = IRI.create(s_p_piece_A_A);
        /**
         * Regulated entity that tendered the consignment
         * 
         */
        public const string s_p_receivedFrom = "https://onerecord.iata.org/ns/cargo/SecurityDeclaration#receivedFrom";
        //public final static IRI p_receivedFrom = IRI.create(s_p_receivedFrom);
        /**
         * Regulated entity issuing the Security Declaration
         * 
         */
        public const string s_p_regulatedEntityIssuer = "https://onerecord.iata.org/ns/cargo/SecurityDeclaration#regulatedEntityIssuer";
        //public final static IRI p_regulatedEntityIssuer = IRI.create(s_p_regulatedEntityIssuer);
        /**
         * Reference to the IoT Device to which the sensor is linked
         * 
         */
        public const string s_p_iotDevice = "https://onerecord.iata.org/ns/cargo/Sensor#iotDevice";
        //public final static IRI p_iotDevice = IRI.create(s_p_iotDevice);
        /**
         * Reference to the measurements recorded by the geolocation sensor
         * 
         */
        public const string s_p_val = "https://onerecord.iata.org/ns/cargo/SensorGeoloc#val";
        //public final static IRI p_val = IRI.create(s_p_val);
        /**
         * Reference to the measurements recorded by the sensor
         * 
         */
        public const string s_p_val_A = "https://onerecord.iata.org/ns/cargo/SensorOther#val";
        //public final static IRI p_val_A = IRI.create(s_p_val_A);
        /**
         * Details of contained piece(s)
         * 
         */
        public const string s_p_containedPieces_A = "https://onerecord.iata.org/ns/cargo/Shipment#containedPieces";
        //public final static IRI p_containedPieces_A = IRI.create(s_p_containedPieces_A);
        /**
         * Name and UN/LOCODE code of the point or port of departure, shipment or destination, as required under the applicable delivery term
         * 
         */
        public const string s_p_deliveryLocation = "https://onerecord.iata.org/ns/cargo/Shipment#deliveryLocation";
        //public final static IRI p_deliveryLocation = IRI.create(s_p_deliveryLocation);
        /**
         * Dimensions details
         * 
         */
        public const string s_p_dimensions_A_A = "https://onerecord.iata.org/ns/cargo/Shipment#dimensions";
        //public final static IRI p_dimensions_A_A = IRI.create(s_p_dimensions_A_A);
        /**
         * Reference document details
         * 
         */
        public const string s_p_externalReferences_A = "https://onerecord.iata.org/ns/cargo/Shipment#externalReferences";
        //public final static IRI p_externalReferences_A = IRI.create(s_p_externalReferences_A);
        /**
         * Reference to the freight forwarder
         * 
         */
        public const string s_p_freightForwarder_A_A = "https://onerecord.iata.org/ns/cargo/Shipment#freightForwarder";
        //public final static IRI p_freightForwarder_A_A = IRI.create(s_p_freightForwarder_A_A);
        /**
         * Insurance details
         * 
         */
        public const string s_p_insurance = "https://onerecord.iata.org/ns/cargo/Shipment#insurance";
        //public final static IRI p_insurance = IRI.create(s_p_insurance);
        /**
         * Parties details
         * 
         */
        public const string s_p_parties_A_A_A_A = "https://onerecord.iata.org/ns/cargo/Shipment#parties";
        //public final static IRI p_parties_A_A_A_A = IRI.create(s_p_parties_A_A_A_A);
        /**
         * Reference to the shipper
         * 
         */
        public const string s_p_shipper_A_A_A = "https://onerecord.iata.org/ns/cargo/Shipment#shipper";
        //public final static IRI p_shipper_A_A_A = IRI.create(s_p_shipper_A_A_A);
        /**
         * Weight details
         * 
         */
        public const string s_p_totalGrossWeight = "https://onerecord.iata.org/ns/cargo/Shipment#totalGrossWeight";
        //public final static IRI p_totalGrossWeight = IRI.create(s_p_totalGrossWeight);
        /**
         * Volumetric weight details
         * 
         */
        public const string s_p_volumetricWeight_A = "https://onerecord.iata.org/ns/cargo/Shipment#volumetricWeight";
        //public final static IRI p_volumetricWeight_A = IRI.create(s_p_volumetricWeight_A);
        /**
         * Waybill unique identifier (AWB or HWB)
         * 
         */
        public const string s_p_waybillNumber_A_A = "https://onerecord.iata.org/ns/cargo/Shipment#waybillNumber";
        //public final static IRI p_waybillNumber_A_A = IRI.create(s_p_waybillNumber_A_A);
        /**
         * Company operating the transport means
         * 
         */
        public const string s_p_transportCompany = "https://onerecord.iata.org/ns/cargo/TransportMeans#transportCompany";
        //public final static IRI p_transportCompany = IRI.create(s_p_transportCompany);
        /**
         * Transport Movement on which the Transport Means is used
         * 
         */
        public const string s_p_transportMovement_A_A_A_A_A = "https://onerecord.iata.org/ns/cargo/TransportMeans#transportMovement";
        //public final static IRI p_transportMovement_A_A_A_A_A = IRI.create(s_p_transportMovement_A_A_A_A_A);
        /**
         * Associated transport segment
         * 
         */
        public const string s_p_transportSegment = "https://onerecord.iata.org/ns/cargo/TransportMeans#transportSegment";
        //public final static IRI p_transportSegment = IRI.create(s_p_transportSegment);
        /**
         * Required for some CO2 calculations
         * 
         */
        public const string s_p_typicalCO2Coefficient = "https://onerecord.iata.org/ns/cargo/TransportMeans#typicalCO2Coefficient";
        //public final static IRI p_typicalCO2Coefficient = IRI.create(s_p_typicalCO2Coefficient);
        /**
         * Typical fuel comsumption (e.g. 20 000L / 1 000nm)
         * 
         */
        public const string s_p_typicalFuelConsumption = "https://onerecord.iata.org/ns/cargo/TransportMeans#typicalFuelConsumption";
        //public final static IRI p_typicalFuelConsumption = IRI.create(s_p_typicalFuelConsumption);
        /**
         * Arrival location details
         * 
         */
        public const string s_p_arrivalLocation_A_A = "https://onerecord.iata.org/ns/cargo#arrivalLocation";
        //public final static IRI p_arrivalLocation_A_A = IRI.create(s_p_arrivalLocation_A_A);
        /**
         * Method of calculation of the CO2 emissions
         * 
         */
        public const string s_p_co2CalculationMethod = "https://onerecord.iata.org/ns/cargo#co2CalculationMethod";
        //public final static IRI p_co2CalculationMethod = IRI.create(s_p_co2CalculationMethod);
        /**
         * Amount of CO2 emitted (e.g. 34 kg/km)
         * 
         */
        public const string s_p_co2Emissions = "https://onerecord.iata.org/ns/cargo#co2Emissions";
        //public final static IRI p_co2Emissions = IRI.create(s_p_co2Emissions);
        /**
         * Departure location details
         * 
         */
        public const string s_p_departureLocation_A_A = "https://onerecord.iata.org/ns/cargo#departureLocation";
        //public final static IRI p_departureLocation_A_A = IRI.create(s_p_departureLocation_A_A);
        /**
         * Distance calculated if distance measured is not available
         * 
         */
        public const string s_p_distanceCalculated = "https://onerecord.iata.org/ns/cargo#distanceCalculated";
        //public final static IRI p_distanceCalculated = IRI.create(s_p_distanceCalculated);
        /**
         * Distance measured
         * 
         */
        public const string s_p_distanceMeasured = "https://onerecord.iata.org/ns/cargo#distanceMeasured";
        //public final static IRI p_distanceMeasured = IRI.create(s_p_distanceMeasured);
        /**
         * Reference to document or logistics object (URI)
         * 
         */
        public const string s_p_externalReferences_A_A = "https://onerecord.iata.org/ns/cargo#externalReferences";
        //public final static IRI p_externalReferences_A_A = IRI.create(s_p_externalReferences_A_A);
        /**
         * calculated fuel consumption, if measured not available
         * 
         */
        public const string s_p_fuelAmountCalculated = "https://onerecord.iata.org/ns/cargo#fuelAmountCalculated";
        //public final static IRI p_fuelAmountCalculated = IRI.create(s_p_fuelAmountCalculated);
        /**
         * actual measured fuel consumption
         * 
         */
        public const string s_p_fuelAmountMeasured = "https://onerecord.iata.org/ns/cargo#fuelAmountMeasured";
        //public final static IRI p_fuelAmountMeasured = IRI.create(s_p_fuelAmountMeasured);
        /**
         * Reference to all Movement Times such as Departure, Arrival, etc.
         * 
         */
        public const string s_p_movementTimes = "https://onerecord.iata.org/ns/cargo#movementTimes";
        //public final static IRI p_movementTimes = IRI.create(s_p_movementTimes);
        /**
         * Actual payload for the transport
         * 
         */
        public const string s_p_payload = "https://onerecord.iata.org/ns/cargo#payload";
        //public final static IRI p_payload = IRI.create(s_p_payload);
        /**
         * Transport means details
         * 
         */
        public const string s_p_transportMeans = "https://onerecord.iata.org/ns/cargo#transportMeans";
        //public final static IRI p_transportMeans = IRI.create(s_p_transportMeans);
        /**
         * Name of the person operating the transport means (e.g. aircraft captain, truck driver)
         * 
         */
        public const string s_p_transportMeansOperators = "https://onerecord.iata.org/ns/cargo#transportMeansOperators";
        //public final static IRI p_transportMeansOperators = IRI.create(s_p_transportMeansOperators);
        /**
         * Pieces assigned to the transport segment
         * 
         */
        public const string s_p_transportedPieces = "https://onerecord.iata.org/ns/cargo#transportedPieces";
        //public final static IRI p_transportedPieces = IRI.create(s_p_transportedPieces);
        /**
         * ULDs assigned to the transport segment
         * 
         */
        public const string s_p_transportedUlds = "https://onerecord.iata.org/ns/cargo#transportedUlds";
        //public final static IRI p_transportedUlds = IRI.create(s_p_transportedUlds);
        /**
         * Reference documents details 
         * 
         */
        public const string s_p_externalReference = "https://onerecord.iata.org/ns/cargo/ULD#externalReference";
        //public final static IRI p_externalReference = IRI.create(s_p_externalReference);
        /**
         * Tare weight of the empty ULD
         * 
         */
        public const string s_p_tareWeight = "https://onerecord.iata.org/ns/cargo/ULD#tareWeight";
        //public final static IRI p_tareWeight = IRI.create(s_p_tareWeight);
        /**
         * Transport Movements on which the ULD are transported
         * 
         */
        public const string s_p_transportMovements_A = "https://onerecord.iata.org/ns/cargo/ULD#transportMovements";
        //public final static IRI p_transportMovements_A = IRI.create(s_p_transportMovements_A);
        /**
         * Segment related to the ULD movement
         * 
         */
        public const string s_p_transportSegments_A = "https://onerecord.iata.org/ns/cargo/ULD#transportSegments";
        //public final static IRI p_transportSegments_A = IRI.create(s_p_transportSegments_A);
        /**
         * Details of contained (virtual) piece(s)
         * 
         */
        public const string s_p_upid = "https://onerecord.iata.org/ns/cargo/ULD#upid";
        //public final static IRI p_upid = IRI.create(s_p_upid);
        /**
         * Chargeable weight
         * 
         */
        public const string s_p_chargeableWeight = "https://onerecord.iata.org/ns/cargo/VolumetricWeight#chargeableWeight";
        //public final static IRI p_chargeableWeight = IRI.create(s_p_chargeableWeight);
        /**
         * Volume to weight conversion factor
         * 
         */
        public const string s_p_conversionFactor = "https://onerecord.iata.org/ns/cargo/VolumetricWeight#conversionFactor";
        //public final static IRI p_conversionFactor = IRI.create(s_p_conversionFactor);
        /**
         * Refers to the Booking option
         * 
         */
        public const string s_p_booking = "https://onerecord.iata.org/ns/cargo/Waybill#booking";
        //public final static IRI p_booking = IRI.create(s_p_booking);
        /**
         * Refers to the Booking 
         * 
         */
        public const string s_p_bookingRef_A = "https://onerecord.iata.org/ns/cargo/Waybill#bookingRef";
        //public final static IRI p_bookingRef_A = IRI.create(s_p_bookingRef_A);
        /**
         * Location of individual or company involved in the movement of a consignment or Coded representation of a specific airport/city code
         * 
         */
        public const string s_p_carrierDeclarationPlace = "https://onerecord.iata.org/ns/cargo/Waybill#carrierDeclarationPlace";
        //public final static IRI p_carrierDeclarationPlace = IRI.create(s_p_carrierDeclarationPlace);
        /**
         * Refers to the Waybill(s) contained
         * 
         */
        public const string s_p_containedWaybills = "https://onerecord.iata.org/ns/cargo/Waybill#containedWaybills";
        //public final static IRI p_containedWaybills = IRI.create(s_p_containedWaybills);
        public const string s_p_topDataProperty = "http://www.w3.org/2002/07/owl#topDataProperty";
        //public final static IRI p_topDataProperty = IRI.create(s_p_topDataProperty);
        /**
         * Address identifier using special coding systems e.g. US CBP FIRMS code
         * 
         */
        public const string s_p_addressCode = "https://onerecord.iata.org/ns/cargo/Address#addressCode";
        //public final static IRI p_addressCode = IRI.create(s_p_addressCode);
        /**
         * Type of address code e.g. US CBP FIRMS
         * 
         */
        public const string s_p_addressCodeType = "https://onerecord.iata.org/ns/cargo/Address#addressCodeType";
        //public final static IRI p_addressCodeType = IRI.create(s_p_addressCodeType);
        /**
         * UN/LOCODE city code (5 letter) or IATA city code (3 letter)
         * 
         */
        public const string s_p_cityCode = "https://onerecord.iata.org/ns/cargo/Address#cityCode";
        //public final static IRI p_cityCode = IRI.create(s_p_cityCode);
        /**
         * If no CityCode provided, full name of the city 
         * 
         */
        public const string s_p_cityName = "https://onerecord.iata.org/ns/cargo/Address#cityName";
        //public final static IRI p_cityName = IRI.create(s_p_cityName);
        /**
         * Post Office box number / code
         * 
         */
        public const string s_p_poBox = "https://onerecord.iata.org/ns/cargo/Address#poBox";
        //public final static IRI p_poBox = IRI.create(s_p_poBox);
        /**
         * Postal / ZIP code
         * 
         */
        public const string s_p_postalCode = "https://onerecord.iata.org/ns/cargo/Address#postalCode";
        //public final static IRI p_postalCode = IRI.create(s_p_postalCode);
        /**
         * Region/ State / Department. Refer ISO 3166-2
         * 
         */
        public const string s_p_regionCode = "https://onerecord.iata.org/ns/cargo/Address#regionCode";
        //public final static IRI p_regionCode = IRI.create(s_p_regionCode);
        /**
         * If no StateCode provided, full name of the region / state / province / canton
         * 
         */
        public const string s_p_regionName = "https://onerecord.iata.org/ns/cargo/Address#regionName";
        //public final static IRI p_regionName = IRI.create(s_p_regionName);
        /**
         * Street address including street name, street number, building number, apartment etc
         * 
         */
        public const string s_p_street = "https://onerecord.iata.org/ns/cargo/Address#street";
        //public final static IRI p_street = IRI.create(s_p_street);
        /**
         * Status of the Booking with regards to the step in the Sales and Booking process: Quoted, Booked (to be confirmed)
         * 
         */
        public const string s_p_bookingStatus = "https://onerecord.iata.org/ns/cargo#bookingStatus";
        //public final static IRI p_bookingStatus = IRI.create(s_p_bookingStatus);
        /**
         * Starting datetime of availability of the booking option
         * 
         */
        public const string s_p_offerValidFrom = "https://onerecord.iata.org/ns/cargo#offerValidFrom";
        //public final static IRI p_offerValidFrom = IRI.create(s_p_offerValidFrom);
        /**
         * Ending datetime of availability of the booking option
         * 
         */
        public const string s_p_offerValidTo = "https://onerecord.iata.org/ns/cargo#offerValidTo";
        //public final static IRI p_offerValidTo = IRI.create(s_p_offerValidTo);
        /**
         * Indicates if the offer is a perfect match to the quote request (boolean)
         * 
         */
        public const string s_p_requestMatchInd = "https://onerecord.iata.org/ns/cargo#requestMatchInd";
        //public final static IRI p_requestMatchInd = IRI.create(s_p_requestMatchInd);
        /**
         * Indicate the secruty state of the shipment, screened or not
         * 
         */
        public const string s_p_shipmentSecurityStatus = "https://onerecord.iata.org/ns/cargo#shipmentSecurityStatus";
        //public final static IRI p_shipmentSecurityStatus = IRI.create(s_p_shipmentSecurityStatus);
        /**
         * Reference to the Allotment as per the contracts between forwarders and carriers
         * 
         */
        public const string s_p_allotment = "https://onerecord.iata.org/ns/cargo#allotment";
        //public final static IRI p_allotment = IRI.create(s_p_allotment);
        /**
         * Expected commodity for quote request purposes only. To be defined by MCD
         * 
         */
        public const string s_p_expectedCommodities = "https://onerecord.iata.org/ns/cargo#expectedCommodities";
        //public final static IRI p_expectedCommodities = IRI.create(s_p_expectedCommodities);
        /**
         * Identification of the request type: Quote or Booking (to be confirmed)
         * 
         */
        public const string s_p_requestType = "https://onerecord.iata.org/ns/cargo#requestType";
        //public final static IRI p_requestType = IRI.create(s_p_requestType);
        /**
         * Requested handling information for quote request purposes only
         * 
         */
        public const string s_p_requestedHandling = "https://onerecord.iata.org/ns/cargo#requestedHandling";
        //public final static IRI p_requestedHandling = IRI.create(s_p_requestedHandling);
        /**
         * Indicate the security state of the shipment, screened or not
         * 
         */
        public const string s_p_shipmentSecurityStatus_A = "https://onerecord.iata.org/ns/cargo#shipmentSecurityStatus";
        //public final static IRI p_shipmentSecurityStatus_A = IRI.create(s_p_shipmentSecurityStatus_A);
        /**
         * When part of the Request it refers to the preferred Transport ID from the customer. When part of the BookingOption (offer or actual booking) it refers to the expected Transport ID or flight
         * 
         */
        public const string s_p_preferredTransportId = "https://onerecord.iata.org/ns/cargo/Segment#preferredTransportId";
        //public final static IRI p_preferredTransportId = IRI.create(s_p_preferredTransportId);
        /**
         * Earliest acceptance date time (requested or proposed)
         * 
         */
        public const string s_p_earliestAcceptanceTime = "https://onerecord.iata.org/ns/cargo/Times#earliestAcceptanceTime";
        //public final static IRI p_earliestAcceptanceTime = IRI.create(s_p_earliestAcceptanceTime);
        /**
         * Latest Acceptance time as per cargo/IQ definition (requested, proposed or actual)
         * 
         */
        public const string s_p_latestAcceptanceTime = "https://onerecord.iata.org/ns/cargo/Times#latestAcceptanceTime";
        //public final static IRI p_latestAcceptanceTime = IRI.create(s_p_latestAcceptanceTime);
        /**
         * Time of availability of the shipment as per cargo/IQ definition
         * 
         */
        public const string s_p_timeOfAvailability = "https://onerecord.iata.org/ns/cargo/Times#timeOfAvailability";
        //public final static IRI p_timeOfAvailability = IRI.create(s_p_timeOfAvailability);
        /**
         * Total transit time as per cargo/IQ definition, expressed as a duration
         * 
         */
        public const string s_p_totalTransitTime = "https://onerecord.iata.org/ns/cargo/Times#totalTransitTime";
        //public final static IRI p_totalTransitTime = IRI.create(s_p_totalTransitTime);
        /**
         * Name of the CO2 calculation method
         * 
         */
        public const string s_p_methodName = "https://onerecord.iata.org/ns/cargo/CO2Emissions#methodName";
        //public final static IRI p_methodName = IRI.create(s_p_methodName);
        /**
         * Version used for the calculation
         * 
         */
        public const string s_p_methodVersion = "https://onerecord.iata.org/ns/cargo/CO2Emissions#methodVersion";
        //public final static IRI p_methodVersion = IRI.create(s_p_methodVersion);
        /**
         * IATA two-character airline code
         * 
         */
        public const string s_p_airlineCode = "https://onerecord.iata.org/ns/cargo/Carrier#airlineCode";
        //public final static IRI p_airlineCode = IRI.create(s_p_airlineCode);
        /**
         * IATA three-numeric airline prefix number
         * 
         */
        public const string s_p_airlinePrefix = "https://onerecord.iata.org/ns/cargo/Carrier#airlinePrefix";
        //public final static IRI p_airlinePrefix = IRI.create(s_p_airlinePrefix);
        /**
         * Official carrier name
         * 
         */
        public const string s_p_carrierName = "https://onerecord.iata.org/ns/cargo/Carrier#carrierName";
        //public final static IRI p_carrierName = IRI.create(s_p_carrierName);
        /**
         * Carrier short name if any
         * 
         */
        public const string s_p_carrierShortName = "https://onerecord.iata.org/ns/cargo/Carrier#carrierShortName";
        //public final static IRI p_carrierShortName = IRI.create(s_p_carrierShortName);
        /**
         * Carrier's product code
         * 
         */
        public const string s_p_productCode = "https://onerecord.iata.org/ns/cargo/CarrierProduct#productCode";
        //public final static IRI p_productCode = IRI.create(s_p_productCode);
        /**
         * Carrier's product description
         * 
         */
        public const string s_p_productDescription = "https://onerecord.iata.org/ns/cargo/CarrierProduct#productDescription";
        //public final static IRI p_productDescription = IRI.create(s_p_productDescription);
        /**
         * Product characteristics code - e.g. CLR - Color. Not restricted to a list.
         * 
         */
        public const string s_p_characteristicsType = "https://onerecord.iata.org/ns/cargo/Characteristics#characteristicsType";
        //public final static IRI p_characteristicsType = IRI.create(s_p_characteristicsType);
        /**
         * Product characteristics value / attribute - e.g. Blue...
         * 
         */
        public const string s_p_value = "https://onerecord.iata.org/ns/cargo/Characteristics#value";
        //public final static IRI p_value = IRI.create(s_p_value);
        /**
         * Company identifier from the Internet of Logistics of the entity that hosts the Common Object.
         * 
         */
        public const string s_p_companyIdentifier = "https://onerecord.iata.org/ns/cargo/CommonObjects#companyIdentifier";
        //public final static IRI p_companyIdentifier = IRI.create(s_p_companyIdentifier);
        /**
         * Name of company or organization
         * 
         */
        public const string s_p_companyName = "https://onerecord.iata.org/ns/cargo/Company#companyName";
        //public final static IRI p_companyName = IRI.create(s_p_companyName);
        /**
         * IATA accredited cargo/ agent 7 digit number
         * 
         */
        public const string s_p_iataCargoAgentCode = "https://onerecord.iata.org/ns/cargo/Company#iatacargo/AgentCode";
        //public final static IRI p_iatacargo/AgentCode = IRI.create(s_p_iatacargo/AgentCode);
        /**
         * Company branch name
         * 
         */
        public const string s_p_branchName = "https://onerecord.iata.org/ns/cargo#branchName";
        //public final static IRI p_branchName = IRI.create(s_p_branchName);
        /**
         * IATA CASS cargo/ agent 4 digit branch number / location identifier
         * 
         */
        public const string s_p_iataCargoAgentLocationIdentifier = "https://onerecord.iata.org/ns/cargo#iatacargo/AgentLocationIdentifier";
        //public final static IRI p_iatacargo/AgentLocationIdentifier = IRI.create(s_p_iatacargo/AgentLocationIdentifier);
        /**
         * Type of the contact details, e.g. Phone number, Mail address
         * 
         */
        public const string s_p_contactType = "https://onerecord.iata.org/ns/cargo/Contact#contactType";
        //public final static IRI p_contactType = IRI.create(s_p_contactType);
        /**
         * Value of the contact detail, e.g. phone number
         * 
         */
        public const string s_p_contactValue = "https://onerecord.iata.org/ns/cargo/Contact#contactValue";
        //public final static IRI p_contactValue = IRI.create(s_p_contactValue);
        /**
         * Country ISO code. Refer ISO 3166-2
         * 
         */
        public const string s_p_countryCode = "https://onerecord.iata.org/ns/cargo/Country#countryCode";
        //public final static IRI p_countryCode = IRI.create(s_p_countryCode);
        /**
         * Full country name, Refer ISO 3166-2
         * 
         */
        public const string s_p_countryName = "https://onerecord.iata.org/ns/cargo/Country#countryName";
        //public final static IRI p_countryName = IRI.create(s_p_countryName);
        /**
         * Customs, Security and Regulatory Control Information Identifier. Coded indicator qualifying Customs related information: Item Number "I", Exemption Legend "L", System Downtime Reference "S", Unique Consignment Reference Number "U", Movement Reference Number "M" .
         * Refers to Code List 1.100
         * Condition: At least one of the three elements (Country Code, Information Identifier or Customs, Security and Regulatory Control Information Identifier) must be completed
         * 
         */
        public const string s_p_customsInfoContentCode = "https://onerecord.iata.org/ns/cargo/CustomsInfo#customsInfoContentCode";
        //public final static IRI p_customsInfoContentCode = IRI.create(s_p_customsInfoContentCode);
        /**
         * Customs country code. Refer ISO 3166-2
         * Condition:  At least one of the three elements (Country Code, Information Identifier or Customs, Security and Regulatory Control Information Identifier) must be completed
         * 
         */
        public const string s_p_customsInfoCountryCode = "https://onerecord.iata.org/ns/cargo/CustomsInfo#customsInfoCountryCode";
        //public final static IRI p_customsInfoCountryCode = IRI.create(s_p_customsInfoCountryCode);
        /**
         * Free text for customs remarks, not used in OCI Composition Rules Table
         * 
         */
        public const string s_p_customsInfoNote = "https://onerecord.iata.org/ns/cargo/CustomsInfo#customsInfoNote";
        //public final static IRI p_customsInfoNote = IRI.create(s_p_customsInfoNote);
        /**
         * Information Identifier. Code identifying a piece of information/entity e.g. "IMP" for import, "EXP" for export, "AGT" for Agent, "ISS" for The Regulated Agent Issuing the Security Status for a Consignment etc. 
         * Condition: At least one of the three elements (Country Code, Information Identifier or Customs, Security and Regulatory Control Information Identifier) must be completed
         * 
         */
        public const string s_p_customsInfoSubjectCode = "https://onerecord.iata.org/ns/cargo/CustomsInfo#customsInfoSubjectCode";
        //public final static IRI p_customsInfoSubjectCode = IRI.create(s_p_customsInfoSubjectCode);
        /**
         * Supplementary Customs, Security and Regulatory Control Information
         * 
         */
        public const string s_p_customsInformation = "https://onerecord.iata.org/ns/cargo/CustomsInfo#customsInformation";
        //public final static IRI p_customsInformation = IRI.create(s_p_customsInformation);
        /**
         * Contains the Special Handling Code related to the prescribed limitation. Hardcoded to PASSENGER AND cargo/ AIRCRAFT or cargo/ AIRCRAFT ONLY. This field is mandatory for air (Air) 
         * 
         */
        public const string s_p_aircraftLimitationInformation = "https://onerecord.iata.org/ns/cargo/DgDeclaration#aircraftLimitationInformation";
        //public final static IRI p_aircraftLimitationInformation = IRI.create(s_p_aircraftLimitationInformation);
        /**
         * Contains the warning message complying with the regulations text note. This field is mandatory for air (Air) 
         * 
         */
        public const string s_p_complianceDeclarationText = "https://onerecord.iata.org/ns/cargo/DgDeclaration#complianceDeclarationText";
        //public final static IRI p_complianceDeclarationText = IRI.create(s_p_complianceDeclarationText);
        /**
         * Indicates an exclusive use shipment
         * 
         */
        public const string s_p_exclusiveUseIndicator = "https://onerecord.iata.org/ns/cargo/DgDeclaration#exclusiveUseIndicator";
        //public final static IRI p_exclusiveUseIndicator = IRI.create(s_p_exclusiveUseIndicator);
        /**
         * Free text. This may include items such as Control temperature for substances stabilized by temperature control, name and telephone number of a responsible person for infectious substances. 
         * 
         */
        public const string s_p_handlingInformation = "https://onerecord.iata.org/ns/cargo/DgDeclaration#handlingInformation";
        //public final static IRI p_handlingInformation = IRI.create(s_p_handlingInformation);
        /**
         * Contains the shipper's declaration to comply with the regulations text note. Free text . This field is mandatory for air (Air)
         * 
         */
        public const string s_p_shipperDeclarationText = "https://onerecord.iata.org/ns/cargo/DgDeclaration#shipperDeclarationText";
        //public final static IRI p_shipperDeclarationText = IRI.create(s_p_shipperDeclarationText);
        /**
         * The category of the package or all packed in one. Complete text to be transmitted: I-White, II-Yellow, III-Yellow instead of I, II, III
         * 
         */
        public const string s_p_dgRaTypeCode = "https://onerecord.iata.org/ns/cargo/DgProductRadioactive#dgRaTypeCode";
        //public final static IRI p_dgRaTypeCode = IRI.create(s_p_dgRaTypeCode);
        /**
         * Indicates if Fissile is excepted
         * 
         */
        public const string s_p_fissileExceptionIndicator = "https://onerecord.iata.org/ns/cargo/DgProductRadioactive#fissileExceptionIndicator";
        //public final static IRI p_fissileExceptionIndicator = IRI.create(s_p_fissileExceptionIndicator);
        /**
         * Fissile exception reference, mandatory if Fissile Exception Indicator is true.
         * 
         */
        public const string s_p_fissileExceptionReference = "https://onerecord.iata.org/ns/cargo/DgProductRadioactive#fissileExceptionReference";
        //public final static IRI p_fissileExceptionReference = IRI.create(s_p_fissileExceptionReference);
        /**
         * Radioactive Transport-Index value of the package or all packed in one. Conditionally mandator and applies to categories II-Yellow and III-Yellow only; field only contains the value, if printed, TI must be added as a prefix to the value  to be printed in the Packing Instructions column
         * 
         */
        public const string s_p_transportIndexNumeric = "https://onerecord.iata.org/ns/cargo/DgProductRadioactive#transportIndexNumeric";
        //public final static IRI p_transportIndexNumeric = IRI.create(s_p_transportIndexNumeric);
        /**
         * Numeric expression of the activity of a radioactive Item
         * 
         */
        public const string s_p_activityLevelMeasure = "https://onerecord.iata.org/ns/cargo/DgRadioactiveIsotope#activityLevelMeasure";
        //public final static IRI p_activityLevelMeasure = IRI.create(s_p_activityLevelMeasure);
        /**
         * Applies to fissile material only, other than fissile excepted. A numeric value expressed to one decimal place preceded by the letters CSI.
         * 
         */
        public const string s_p_criticalitySafetyIndexNumeric = "https://onerecord.iata.org/ns/cargo/DgRadioactiveIsotope#criticalitySafetyIndexNumeric";
        //public final static IRI p_criticalitySafetyIndexNumeric = IRI.create(s_p_criticalitySafetyIndexNumeric);
        /**
         * Id of each radionuclide or for mixtures of radionuclides.
         * 
         */
        public const string s_p_isotopeId = "https://onerecord.iata.org/ns/cargo/DgRadioactiveIsotope#isotopeId";
        //public final static IRI p_isotopeId = IRI.create(s_p_isotopeId);
        /**
         * The name or symbol of each radionuclide or for mixtures of radionuclides, an appropriate general description, or a list of the most restrictive radionuclides. 
         * 
         */
        public const string s_p_isotopeName = "https://onerecord.iata.org/ns/cargo/DgRadioactiveIsotope#isotopeName";
        //public final static IRI p_isotopeName = IRI.create(s_p_isotopeName);
        /**
         * A notation that the material is low dispersible radioactive material.
         * 
         */
        public const string s_p_lowDispersibleIndicator = "https://onerecord.iata.org/ns/cargo/DgRadioactiveIsotope#lowDispersibleIndicator";
        //public final static IRI p_lowDispersibleIndicator = IRI.create(s_p_lowDispersibleIndicator);
        /**
         * A description of the physical and chemical form of the material.
         * 
         */
        public const string s_p_physicalChemicalForm = "https://onerecord.iata.org/ns/cargo/DgRadioactiveIsotope#physicalChemicalForm";
        //public final static IRI p_physicalChemicalForm = IRI.create(s_p_physicalChemicalForm);
        /**
         * A notation that the material is special form
         * 
         */
        public const string s_p_specialFormIndicator = "https://onerecord.iata.org/ns/cargo/DgRadioactiveIsotope#specialFormIndicator";
        //public final static IRI p_specialFormIndicator = IRI.create(s_p_specialFormIndicator);
        /**
         * Company identifier from the Internet of Logistics of the entity that hosts the Embedded Object.
         * 
         */
        public const string s_p_companyIdentifier_A = "https://onerecord.iata.org/ns/cargo/EmbeddedObjects#companyIdentifier";
        //public final static IRI p_companyIdentifier_A = IRI.create(s_p_companyIdentifier_A);
        /**
         * total number of specimens exported in the current calendar year and the current annuela quota for the species concerned (box 11a)
         * 
         */
        public const string s_p_usedToDateQuotaQuantity = "https://onerecord.iata.org/ns/cargo/EpermitConsignment#usedToDateQuotaQuantity";
        //public final static IRI p_usedToDateQuotaQuantity = IRI.create(s_p_usedToDateQuotaQuantity);
        /**
         * Security Stamp ID
         * 
         */
        public const string s_p_securityStampId = "https://onerecord.iata.org/ns/cargo/EpermitSignature#securityStampId";
        //public final static IRI p_securityStampId = IRI.create(s_p_securityStampId);
        /**
         * Role of the signatory with regards to the ePermit: Applicant, Permit issuer, Issuing Authority or Examining authority
         * 
         */
        public const string s_p_signatoryRole = "https://onerecord.iata.org/ns/cargo/EpermitSignature#signatoryRole";
        //public final static IRI p_signatoryRole = IRI.create(s_p_signatoryRole);
        /**
         * Date and time of the signature
         * 
         */
        public const string s_p_signatureDate = "https://onerecord.iata.org/ns/cargo/EpermitSignature#signatureDate";
        //public final static IRI p_signatureDate = IRI.create(s_p_signatureDate);
        /**
         * Signatory signature authentication text
         * 
         */
        public const string s_p_signatureStatement = "https://onerecord.iata.org/ns/cargo/EpermitSignature#signatureStatement";
        //public final static IRI p_signatureStatement = IRI.create(s_p_signatureStatement);
        /**
         * Code specifying a type of government action such as inspection, detention, fumigation, security.
         * 
         */
        public const string s_p_signatureTypeCode = "https://onerecord.iata.org/ns/cargo/EpermitSignature#signatureTypeCode";
        //public final static IRI p_signatureTypeCode = IRI.create(s_p_signatureTypeCode);
        /**
         * Date and time of the event
         * 
         */
        public const string s_p_dateTime = "https://onerecord.iata.org/ns/cargo/Event#dateTime";
        //public final static IRI p_dateTime = IRI.create(s_p_dateTime);
        /**
         * Movement or milestone code. Can refer to CXML Code List 1.18, e.g. DEP, ARR, FOH, RCS but not restricted to it.
         * 
         */
        public const string s_p_eventCode = "https://onerecord.iata.org/ns/cargo/Event#eventCode";
        //public final static IRI p_eventCode = IRI.create(s_p_eventCode);
        /**
         * If no EventCode provided, event name - e.g. Security clearance
         * 
         */
        public const string s_p_eventName = "https://onerecord.iata.org/ns/cargo/Event#eventName";
        //public final static IRI p_eventName = IRI.create(s_p_eventName);
        /**
         * Indicates type of event e.g.  Scheduled, Estimated, Actual
         * 
         */
        public const string s_p_eventTypeIndicator = "https://onerecord.iata.org/ns/cargo/Event#eventTypeIndicator";
        //public final static IRI p_eventTypeIndicator = IRI.create(s_p_eventTypeIndicator);
        /**
         * Position of the shipment in the aircraft - e.g. lower or main deck
         * 
         */
        public const string s_p_loadingPosition = "https://onerecord.iata.org/ns/cargo/EventUld#loadingPosition";
        //public final static IRI p_loadingPosition = IRI.create(s_p_loadingPosition);
        /**
         * Checksum of the document to validate its integrity
         * 
         */
        public const string s_p_documentChecksum = "https://onerecord.iata.org/ns/cargo/ExternalReference#documentChecksum";
        //public final static IRI p_documentChecksum = IRI.create(s_p_documentChecksum);
        /**
         * Unique document identifier
         * 
         */
        public const string s_p_documentId = "https://onerecord.iata.org/ns/cargo/ExternalReference#documentId";
        //public final static IRI p_documentId = IRI.create(s_p_documentId);
        /**
         * Link to the document, e.g. URL of the file where it is hosted
         * 
         */
        public const string s_p_documentLink = "https://onerecord.iata.org/ns/cargo/ExternalReference#documentLink";
        //public final static IRI p_documentLink = IRI.create(s_p_documentLink);
        /**
         * If no DocumentType provided, name of the referenced document 
         * 
         */
        public const string s_p_documentName = "https://onerecord.iata.org/ns/cargo/ExternalReference#documentName";
        //public final static IRI p_documentName = IRI.create(s_p_documentName);
        /**
         * Type of the referenced document . Can refer UNEDIFACT 1001  e.g. 740 - Air Waybill, but not limited to
         * 
         */
        public const string s_p_documentType = "https://onerecord.iata.org/ns/cargo/ExternalReference#documentType";
        //public final static IRI p_documentType = IRI.create(s_p_documentType);
        /**
         * Document version number
         * 
         */
        public const string s_p_documentVersion = "https://onerecord.iata.org/ns/cargo/ExternalReference#documentVersion";
        //public final static IRI p_documentVersion = IRI.create(s_p_documentVersion);
        /**
         * Document expiry date
         * 
         */
        public const string s_p_expiryDate = "https://onerecord.iata.org/ns/cargo/ExternalReference#expiryDate";
        //public final static IRI p_expiryDate = IRI.create(s_p_expiryDate);
        /**
         * Document validity start date
         * 
         */
        public const string s_p_validFrom = "https://onerecord.iata.org/ns/cargo/ExternalReference#validFrom";
        //public final static IRI p_validFrom = IRI.create(s_p_validFrom);
        /**
         * re of the Geolocation coordinates, standard is Degree
         * 
         */
        public const string s_p_geolocationUnit = "https://onerecord.iata.org/ns/cargo/Geolocation#geolocationUnit";
        //public final static IRI p_geolocationUnit = IRI.create(s_p_geolocationUnit);
        /**
         * Location latitude - Change of data type to string as of version 1.2
         * 
         */
        public const string s_p_latitude = "https://onerecord.iata.org/ns/cargo/Geolocation#latitude";
        //public final static IRI p_latitude = IRI.create(s_p_latitude);
        /**
         * Location longitude - Change of data type to string as of version 1.2
         * 
         */
        public const string s_p_longitude = "https://onerecord.iata.org/ns/cargo/Geolocation#longitude";
        //public final static IRI p_longitude = IRI.create(s_p_longitude);
        /**
         * Free text description of the handling instructions
         * 
         */
        public const string s_p_serviceDescription = "https://onerecord.iata.org/ns/cargo/HandlingInstructions#serviceDescription";
        //public final static IRI p_serviceDescription = IRI.create(s_p_serviceDescription);
        /**
         * Refers to the type of handling information provided: Special Service Request (SSR), Special Handling Codes (SPH) or Other Service Information (OSI)
         * 
         */
        public const string s_p_serviceType = "https://onerecord.iata.org/ns/cargo/HandlingInstructions#serviceType";
        //public final static IRI p_serviceType = IRI.create(s_p_serviceType);
        /**
         * Service Type code linked top the Service Type.
         * Refers to Code List 1.14 or 1.16 if service type is Special Handling.
         * 
         */
        public const string s_p_serviceTypeCode = "https://onerecord.iata.org/ns/cargo/HandlingInstructions#serviceTypeCode";
        //public final static IRI p_serviceTypeCode = IRI.create(s_p_serviceTypeCode);
        /**
         * When no value is declared for Insurance this field should be completed with the value TRUE otherwise FALSE
         * 
         */
        public const string s_p_nvdIndicator = "https://onerecord.iata.org/ns/cargo/Insurance#nvdIndicator";
        //public final static IRI p_nvdIndicator = IRI.create(s_p_nvdIndicator);
        /**
         * Reference of the Logistic Object to which the Connected Device is linked (URI)
         * 
         */
        public const string s_p_associatedObject = "https://onerecord.iata.org/ns/cargo/IotDevice#associatedObject";
        //public final static IRI p_associatedObject = IRI.create(s_p_associatedObject);
        /**
         * Natural language description of the device. It can describe how and where the device is attached.
         * 
         */
        public const string s_p_deviceDescription = "https://onerecord.iata.org/ns/cargo/IotDevice#deviceDescription";
        //public final static IRI p_deviceDescription = IRI.create(s_p_deviceDescription);
        /**
         * Commercial denomination of the device
         * 
         */
        public const string s_p_deviceModel = "https://onerecord.iata.org/ns/cargo/IotDevice#deviceModel";
        //public final static IRI p_deviceModel = IRI.create(s_p_deviceModel);
        /**
         * Name of the device defined by the device's owner
         * 
         */
        public const string s_p_deviceName = "https://onerecord.iata.org/ns/cargo/IotDevice#deviceName";
        //public final static IRI p_deviceName = IRI.create(s_p_deviceName);
        /**
         * Serial number that allows to uniquely identify the device
         * 
         */
        public const string s_p_deviceSerialNumber = "https://onerecord.iata.org/ns/cargo/IotDevice#deviceSerialNumber";
        //public final static IRI p_deviceSerialNumber = IRI.create(s_p_deviceSerialNumber);
        /**
         * Production batch number / reference
         * 
         */
        public const string s_p_batchNumber = "https://onerecord.iata.org/ns/cargo/Item#batchNumber";
        //public final static IRI p_batchNumber = IRI.create(s_p_batchNumber);
        /**
         * Production lot number / reference
         * 
         */
        public const string s_p_lotNumber = "https://onerecord.iata.org/ns/cargo/Item#lotNumber";
        //public final static IRI p_lotNumber = IRI.create(s_p_lotNumber);
        /**
         * Product expiry date - e.g. for perishables goods or goods with programmed obsolescence
         * 
         */
        public const string s_p_productExpiryDate = "https://onerecord.iata.org/ns/cargo/Item#productExpiryDate";
        //public final static IRI p_productExpiryDate = IRI.create(s_p_productExpiryDate);
        /**
         * Production date
         * 
         */
        public const string s_p_productionDate = "https://onerecord.iata.org/ns/cargo/Item#productionDate";
        //public final static IRI p_productionDate = IRI.create(s_p_productionDate);
        /**
         * Product quantity for unit price - e.g. 12 (eggs for one USD 1)
         * 
         */
        public const string s_p_quantityForUnitPrice = "https://onerecord.iata.org/ns/cargo/Item#quantityForUnitPrice";
        //public final static IRI p_quantityForUnitPrice = IRI.create(s_p_quantityForUnitPrice);
        /**
         * Reportable quantities, To and from the USA only
         * 
         */
        public const string s_p_reportableQuantity = "https://onerecord.iata.org/ns/cargo/ItemDg#reportableQuantity";
        //public final static IRI p_reportableQuantity = IRI.create(s_p_reportableQuantity);
        /**
         * Additional information that may be added in addition to the proper shipping name to more fully describe the goods or to identify a particular condition
         * 
         */
        public const string s_p_supplementaryInfoPrefix = "https://onerecord.iata.org/ns/cargo/ItemDg#supplementaryInfoPrefix";
        //public final static IRI p_supplementaryInfoPrefix = IRI.create(s_p_supplementaryInfoPrefix);
        /**
         * Additional information that may be added in addition to the proper shipping to more fully describe the goods or to identify a particular condition
         * 
         */
        public const string s_p_supplementaryInfoSuffix = "https://onerecord.iata.org/ns/cargo/ItemDg#supplementaryInfoSuffix";
        //public final static IRI p_supplementaryInfoSuffix = IRI.create(s_p_supplementaryInfoSuffix);
        /**
         * Indicates if the permit is a copy (true) or an original (false) (box 1)
         * 
         */
        public const string s_p_permitCopyIndicator = "https://onerecord.iata.org/ns/cargo/LiveAnimalsEpermit#permitCopyIndicator";
        //public final static IRI p_permitCopyIndicator = IRI.create(s_p_permitCopyIndicator);
        /**
         * The original number is a unique number allocated to each document by the relevant Management Authority. (box 1)
         * 
         */
        public const string s_p_permitNumber = "https://onerecord.iata.org/ns/cargo/LiveAnimalsEpermit#permitNumber";
        //public final static IRI p_permitNumber = IRI.create(s_p_permitNumber);
        /**
         * Code specifying the document name. (box 1)
         * 
         */
        public const string s_p_permitTypeCode = "https://onerecord.iata.org/ns/cargo/LiveAnimalsEpermit#permitTypeCode";
        //public final static IRI p_permitTypeCode = IRI.create(s_p_permitTypeCode);
        /**
         * Description if TypeCode is Other (box 1)
         * 
         */
        public const string s_p_permitTypeOther = "https://onerecord.iata.org/ns/cargo/LiveAnimalsEpermit#permitTypeOther";
        //public final static IRI p_permitTypeOther = IRI.create(s_p_permitTypeOther);
        /**
         * Permit Valid from (box 2)
         * 
         */
        public const string s_p_permitValidFrom = "https://onerecord.iata.org/ns/cargo/LiveAnimalsEpermit#permitValidFrom";
        //public final static IRI p_permitValidFrom = IRI.create(s_p_permitValidFrom);
        /**
         * Permit Valid until (box 2)
         * 
         */
        public const string s_p_permitValidUntil = "https://onerecord.iata.org/ns/cargo/LiveAnimalsEpermit#permitValidUntil";
        //public final static IRI p_permitValidUntil = IRI.create(s_p_permitValidUntil);
        /**
         * Special conditions (box 5)
         * 
         */
        public const string s_p_specialConditions = "https://onerecord.iata.org/ns/cargo/LiveAnimalsEpermit#specialConditions";
        //public final static IRI p_specialConditions = IRI.create(s_p_specialConditions);
        /**
         * Code indicating the purpose of the transaction (box 5a)
         * 
         */
        public const string s_p_transactionPurposeCode = "https://onerecord.iata.org/ns/cargo/LiveAnimalsEpermit#transactionPurposeCode";
        //public final static IRI p_transactionPurposeCode = IRI.create(s_p_transactionPurposeCode);
        /**
         * Purpose of the transaction in free text (box 5a)
         * 
         */
        public const string s_p_transactionPurposeText = "https://onerecord.iata.org/ns/cargo/LiveAnimalsEpermit#transactionPurposeText";
        //public final static IRI p_transactionPurposeText = IRI.create(s_p_transactionPurposeText);
        /**
         * Reference to the Air Waybill or other transport contract document (box 15)
         * 
         */
        public const string s_p_transportContractId = "https://onerecord.iata.org/ns/cargo/LiveAnimalsEpermit#transportContractId";
        //public final static IRI p_transportContractId = IRI.create(s_p_transportContractId);
        /**
         * Code specifying the transport document name (box 15)
         * 
         */
        public const string s_p_transportContractTypeCode = "https://onerecord.iata.org/ns/cargo/LiveAnimalsEpermit#transportContractTypeCode";
        //public final static IRI p_transportContractTypeCode = IRI.create(s_p_transportContractTypeCode);
        /**
         * Location code of airport, freight terminal, seaport, rail station. UN/LOCODE city code (5 letter) or IATA airport code (3 letter)
         * 
         */
        public const string s_p_code = "https://onerecord.iata.org/ns/cargo/Location#code";
        //public final static IRI p_code = IRI.create(s_p_code);
        /**
         * Full name of the location
         * 
         */
        public const string s_p_locationName = "https://onerecord.iata.org/ns/cargo/Location#locationName";
        //public final static IRI p_locationName = IRI.create(s_p_locationName);
        /**
         * Location type - e.g. Airport, Freight terminal, Rail station, Seaport, etc
         * 
         */
        public const string s_p_locationType = "https://onerecord.iata.org/ns/cargo/Location#locationType";
        //public final static IRI p_locationType = IRI.create(s_p_locationType);
        /**
         * Company identifier from the Internet of Logistics of the entity that hosts the Logistics Object.
         * 
         */
        public const string s_p_companyIdentifier_A_A = "https://onerecord.iata.org/ns/cargo/LogisticsObject#companyIdentifier";
        //public final static IRI p_companyIdentifier_A_A = IRI.create(s_p_companyIdentifier_A_A);
        /**
         * Timestamp for the measurement
         * 
         */
        public const string s_p_measurementTimestamp = "https://onerecord.iata.org/ns/cargo/Measurements#measurementTimestamp";
        //public final static IRI p_measurementTimestamp = IRI.create(s_p_measurementTimestamp);
        /**
         * Direction to indicate if it's Inbound or Outbound
         * 
         */
        public const string s_p_direction = "https://onerecord.iata.org/ns/cargo/MovementTimes#direction";
        //public final static IRI p_direction = IRI.create(s_p_direction);
        /**
         * The milestone list still needs to be defined, it includes elements from CXML Code List 1.92 but is not limited to those values, e.g. block-on and block-off times might be added as a comparison to wheels off and touchdown.
         * 
         */
        public const string s_p_movementMilestone = "https://onerecord.iata.org/ns/cargo/MovementTimes#movementMilestone";
        //public final static IRI p_movementMilestone = IRI.create(s_p_movementMilestone);
        /**
         * Timestamp (date and time) of the movement time. If the movement time is recorded asynchronously, the timestamp should reflect the actual time, not when the data was created.
         * 
         */
        public const string s_p_movementTimestamp = "https://onerecord.iata.org/ns/cargo/MovementTimes#movementTimestamp";
        //public final static IRI p_movementTimestamp = IRI.create(s_p_movementTimestamp);
        /**
         * The type of time can be Actual, Estimated ot Scheduled
         * 
         */
        public const string s_p_timeType = "https://onerecord.iata.org/ns/cargo/MovementTimes#timeType";
        //public final static IRI p_timeType = IRI.create(s_p_timeType);
        /**
         * Item identifier
         * 
         */
        public const string s_p_identifier = "https://onerecord.iata.org/ns/cargo/OtherIdentifier#identifier";
        //public final static IRI p_identifier = IRI.create(s_p_identifier);
        /**
         * Identifier type or description
         * 
         */
        public const string s_p_otherIdentifierType = "https://onerecord.iata.org/ns/cargo/OtherIdentifier#otherIdentifierType";
        //public final static IRI p_otherIdentifierType = IRI.create(s_p_otherIdentifierType);
        /**
         * Free Text. Describes the package type.
         * 
         */
        public const string s_p_packagingTypeDescription = "https://onerecord.iata.org/ns/cargo/PackagingType#packagingTypeDescription";
        //public final static IRI p_packagingTypeDescription = IRI.create(s_p_packagingTypeDescription);
        /**
         * Packaging type identifier as per UNECE Rec 21 Annex V and VI e.g. 1A - Drum, steel - Packaging material code. Identifies the Logistic Unit package type. UN Recommendation on Transport of Dangerous Goods, Model Regulations 
         * 
         */
        public const string s_p_typeCode = "https://onerecord.iata.org/ns/cargo/PackagingType#typeCode";
        //public final static IRI p_typeCode = IRI.create(s_p_typeCode);
        /**
         * Role fo the Company in the context. Can refer to Code List 1.36 in the CXML Toolkit
         * 
         */
        public const string s_p_partyRole = "https://onerecord.iata.org/ns/cargo/Party#partyRole";
        //public final static IRI p_partyRole = IRI.create(s_p_partyRole);
        /**
         * Contact type - e.g. Emergency contact, Customs contact, Customer contact
         * 
         */
        public const string s_p_contactType_A = "https://onerecord.iata.org/ns/cargo/Person#contactType";
        //public final static IRI p_contactType_A = IRI.create(s_p_contactType_A);
        /**
         * Department / Division / Unit
         * 
         */
        public const string s_p_department = "https://onerecord.iata.org/ns/cargo/Person#department";
        //public final static IRI p_department = IRI.create(s_p_department);
        /**
         * Employee ID
         * 
         */
        public const string s_p_employeeId = "https://onerecord.iata.org/ns/cargo/Person#employeeId";
        //public final static IRI p_employeeId = IRI.create(s_p_employeeId);
        /**
         * First name / given name
         * 
         */
        public const string s_p_firstName = "https://onerecord.iata.org/ns/cargo/Person#firstName";
        //public final static IRI p_firstName = IRI.create(s_p_firstName);
        /**
         * Job title / position
         * 
         */
        public const string s_p_jobTitle = "https://onerecord.iata.org/ns/cargo/Person#jobTitle";
        //public final static IRI p_jobTitle = IRI.create(s_p_jobTitle);
        /**
         * Last name / family name / surname
         * 
         */
        public const string s_p_lastName = "https://onerecord.iata.org/ns/cargo/Person#lastName";
        //public final static IRI p_lastName = IRI.create(s_p_lastName);
        /**
         * Middle name/ other name
         * 
         */
        public const string s_p_middleName = "https://onerecord.iata.org/ns/cargo/Person#middleName";
        //public final static IRI p_middleName = IRI.create(s_p_middleName);
        /**
         * Salutation 
         * 
         */
        public const string s_p_salutation = "https://onerecord.iata.org/ns/cargo/Person#salutation";
        //public final static IRI p_salutation = IRI.create(s_p_salutation);
        /**
         * Coload indicator for the pieces (boolean)
         * 
         */
        public const string s_p_coload = "https://onerecord.iata.org/ns/cargo#coload";
        //public final static IRI p_coload = IRI.create(s_p_coload);
        /**
         * The value of a shipment declared for carriage purposes , NVD if no value declared
         * 
         */
        public const string s_p_declaredValueForCarriage = "https://onerecord.iata.org/ns/cargo#declaredValueForCarriage";
        //public final static IRI p_declaredValueForCarriage = IRI.create(s_p_declaredValueForCarriage);
        /**
         * The value of a shipment declared for customs purposes , NVD if no value declared
         * 
         */
        public const string s_p_declaredValueForCustoms = "https://onerecord.iata.org/ns/cargo#declaredValueForCustoms";
        //public final static IRI p_declaredValueForCustoms = IRI.create(s_p_declaredValueForCustoms);
        /**
         * General goods description
         * 
         */
        public const string s_p_goodsDescription = "https://onerecord.iata.org/ns/cargo#goodsDescription";
        //public final static IRI p_goodsDescription = IRI.create(s_p_goodsDescription);
        /**
         * Specify how the piece will be delivered (bulk or ULD)
         * 
         */
        public const string s_p_loadType = "https://onerecord.iata.org/ns/cargo#loadType";
        //public final static IRI p_loadType = IRI.create(s_p_loadType);
        /**
         * When no value is declared for Carriage, this field may be completed with the value TRUE otherwise FALSE
         * 
         */
        public const string s_p_nvdForCarriage = "https://onerecord.iata.org/ns/cargo#nvdForCarriage";
        //public final static IRI p_nvdForCarriage = IRI.create(s_p_nvdForCarriage);
        /**
         * When no value is declared for Customs, this field may be completed with the value TRUE otherwise FALSE
         * 
         */
        public const string s_p_nvdForCustoms = "https://onerecord.iata.org/ns/cargo#nvdForCustoms";
        //public final static IRI p_nvdForCustoms = IRI.create(s_p_nvdForCustoms);
        /**
         * Reference identifying how the package is marked. Field is hardcode to "SSCC-18", "UPC" or "Other"
         * 
         */
        public const string s_p_packageMarkCoded = "https://onerecord.iata.org/ns/cargo#packageMarkCoded";
        //public final static IRI p_packageMarkCoded = IRI.create(s_p_packageMarkCoded);
        /**
         * SSCC-18 code for the value of the package mark, company or bar code, free text, pallet code, etc.
         * 
         */
        public const string s_p_packagedeIdentifier = "https://onerecord.iata.org/ns/cargo#packagedeIdentifier";
        //public final static IRI p_packagedeIdentifier = IRI.create(s_p_packagedeIdentifier);
        /**
         * Shipping marks
         * 
         */
        public const string s_p_shippingMarks = "https://onerecord.iata.org/ns/cargo#shippingMarks";
        //public final static IRI p_shippingMarks = IRI.create(s_p_shippingMarks);
        /**
         * Shipper's Load And Count  ( total contained piece count as provided by shipper)
         * 
         */
        public const string s_p_slac = "https://onerecord.iata.org/ns/cargo#slac";
        //public final static IRI p_slac = IRI.create(s_p_slac);
        /**
         * Stackable indicator for the pieces (boolean)
         * 
         */
        public const string s_p_stackable = "https://onerecord.iata.org/ns/cargo#stackable";
        //public final static IRI p_stackable = IRI.create(s_p_stackable);
        /**
         * Turnable indicator for the pieces (boolean)
         * 
         */
        public const string s_p_turnable = "https://onerecord.iata.org/ns/cargo#turnable";
        //public final static IRI p_turnable = IRI.create(s_p_turnable);
        /**
         * Unique Piece Identifier (UPID) of the piece. Refer IATA Recommended Practice 1689
         * 
         */
        public const string s_p_upid_A = "https://onerecord.iata.org/ns/cargo#upid";
        //public final static IRI p_upid_A = IRI.create(s_p_upid_A);
        /**
         * A statement identifying that the dangerous goods listed above are all contained in the same outer packaging. Takes the form All packed in one aaaa (description of packaging type) x nn (number of packages). Applies to air transport only. (Air) 
         * 
         */
        public const string s_p_allPackedInOneIndicator = "https://onerecord.iata.org/ns/cargoDg#allPackedInOneIndicator";
        //public final static IRI p_allPackedInOneIndicator = IRI.create(s_p_allPackedInOneIndicator);
        /**
         * Applies to fissile material only, other than fissile excepted. A numeric value expressed to one decimal place preceded by the letters CSI. 
         * 
         */
        public const string s_p_overpackCriticalitySafetyIndexNumeric = "https://onerecord.iata.org/ns/cargoDg#overpackCriticalitySafetyIndexNumeric";
        //public final static IRI p_overpackCriticalitySafetyIndexNumeric = IRI.create(s_p_overpackCriticalitySafetyIndexNumeric);
        /**
         * Overpack indicator 
         * 
         */
        public const string s_p_overpackIndicator = "https://onerecord.iata.org/ns/cargoDg#overpackIndicator";
        //public final static IRI p_overpackIndicator = IRI.create(s_p_overpackIndicator);
        /**
         * A single number assigned to a package, overpack or freight container to provide control over radiation exposure. 
         * 
         */
        public const string s_p_overpackT1 = "https://onerecord.iata.org/ns/cargoDg#overpackT1";
        //public final static IRI p_overpackT1 = IRI.create(s_p_overpackT1);
        /**
         * Identifies the Logistic Unit package type. UN Recommendation on Transport of Dangerous Goods, Model Regulations 
         * 
         */
        public const string s_p_overpackTypeCode = "https://onerecord.iata.org/ns/cargoDg#overpackTypeCode";
        //public final static IRI p_overpackTypeCode = IRI.create(s_p_overpackTypeCode);
        /**
         * Most instances of all packed in one will require the addition of the Q value which  1. Applies to air transport only. (Air)  
         * 
         */
        public const string s_p_qValueNumeric = "https://onerecord.iata.org/ns/cargoDg#qValueNumeric";
        //public final static IRI p_qValueNumeric = IRI.create(s_p_qValueNumeric);
        /**
         * Defined in Resolution Conf. 13.6 and is required for pre-Convention specimens (box 12b)
         * 
         */
        public const string s_p_acquisitionDatetime = "https://onerecord.iata.org/ns/cargoLiveAnimals#acquisitionDatetime";
        //public final static IRI p_acquisitionDatetime = IRI.create(s_p_acquisitionDatetime);
        /**
         * total number of specimens exported in the current calendar year and the current annuela quota for the species concerned (box 11a)
         * 
         */
        public const string s_p_annualQuotaQuantity = "https://onerecord.iata.org/ns/cargoLiveAnimals#annualQuotaQuantity";
        //public final static IRI p_annualQuotaQuantity = IRI.create(s_p_annualQuotaQuantity);
        /**
         * Operations code ID. Refers to the number of the registered captive-breeding or artifical propagation operation (box 12b)
         * 
         */
        public const string s_p_categoryCode = "https://onerecord.iata.org/ns/cargoLiveAnimals#categoryCode";
        //public final static IRI p_categoryCode = IRI.create(s_p_categoryCode);
        /**
         * Appendix number of the convention (I, II or III) (box 10)
         * 
         */
        public const string s_p_goodsTypeCode = "https://onerecord.iata.org/ns/cargoLiveAnimals#goodsTypeCode";
        //public final static IRI p_goodsTypeCode = IRI.create(s_p_goodsTypeCode);
        /**
         * Appendix number of the convention (I, II or III) (box 10)
         * 
         */
        public const string s_p_goodsTypeExtensionCode = "https://onerecord.iata.org/ns/cargoLiveAnimals#goodsTypeExtensionCode";
        //public final static IRI p_goodsTypeExtensionCode = IRI.create(s_p_goodsTypeExtensionCode);
        /**
         * Issuing date for Origin reference permit or re-export reference Certificate (box 12)
         * 
         */
        public const string s_p_originReferencePermitDatetime = "https://onerecord.iata.org/ns/cargoLiveAnimals#originReferencePermitDatetime";
        //public final static IRI p_originReferencePermitDatetime = IRI.create(s_p_originReferencePermitDatetime);
        /**
         * identifier of Origin reference permit or re-export reference Certificate (box 12/12a)
         * 
         */
        public const string s_p_originReferencePermitId = "https://onerecord.iata.org/ns/cargoLiveAnimals#originReferencePermitId";
        //public final static IRI p_originReferencePermitId = IRI.create(s_p_originReferencePermitId);
        /**
         * Document type code of origin reference permit or re-export reference Certificate (box 12/12a)
         * 
         */
        public const string s_p_originReferencePermitTypeCode = "https://onerecord.iata.org/ns/cargoLiveAnimals#originReferencePermitTypeCode";
        //public final static IRI p_originReferencePermitTypeCode = IRI.create(s_p_originReferencePermitTypeCode);
        /**
         * Quantity including units (box 11)
         * 
         */
        public const string s_p_quantityAnimals = "https://onerecord.iata.org/ns/cargoLiveAnimals#quantityAnimals";
        //public final static IRI p_quantityAnimals = IRI.create(s_p_quantityAnimals);
        /**
         * Species common name (box 8)
         * 
         */
        public const string s_p_speciesCommonName = "https://onerecord.iata.org/ns/cargoLiveAnimals#speciesCommonName";
        //public final static IRI p_speciesCommonName = IRI.create(s_p_speciesCommonName);
        /**
         * Species scientific name (box 7)
         * 
         */
        public const string s_p_speciesScientificName = "https://onerecord.iata.org/ns/cargoLiveAnimals#speciesScientificName";
        //public final static IRI p_speciesScientificName = IRI.create(s_p_speciesScientificName);
        /**
         * Description of specimens, including age and sex if LA (box 9)
         * 
         */
        public const string s_p_specimenDescription = "https://onerecord.iata.org/ns/cargoLiveAnimals#specimenDescription";
        //public final static IRI p_specimenDescription = IRI.create(s_p_specimenDescription);
        /**
         * Description of specimens, CITES type code (box 9)
         * 
         */
        public const string s_p_specimenTypeCode = "https://onerecord.iata.org/ns/cargoLiveAnimals#specimenTypeCode";
        //public final static IRI p_specimenTypeCode = IRI.create(s_p_specimenTypeCode);
        /**
         * Charge code for carrier, eg. CA, CB, etc
         * 
         */
        public const string s_p_carrierChargeCode = "https://onerecord.iata.org/ns/cargo/Price#carrierChargeCode";
        //public final static IRI p_carrierChargeCode = IRI.create(s_p_carrierChargeCode);
        /**
         * Total price
         * 
         */
        public const string s_p_grandTotal = "https://onerecord.iata.org/ns/cargo/Price#grandTotal";
        //public final static IRI p_grandTotal = IRI.create(s_p_grandTotal);
        /**
         * Terms of validity
         * 
         */
        public const string s_p_validTo = "https://onerecord.iata.org/ns/cargo/Price#validTo";
        //public final static IRI p_validTo = IRI.create(s_p_validTo);
        /**
         * Indicates the specific commodity on which the rate class code is applied
         * 
         */
        public const string s_p_commodityItemNumber = "https://onerecord.iata.org/ns/cargo/Product#commodityItemNumber";
        //public final static IRI p_commodityItemNumber = IRI.create(s_p_commodityItemNumber);
        /**
         * Harmonized Commodity code, refer to hsType used. 6 minimum digits are expected.
         * 
         */
        public const string s_p_hsCode = "https://onerecord.iata.org/ns/cargo/Product#hsCode";
        //public final static IRI p_hsCode = IRI.create(s_p_hsCode);
        /**
         * Commodity description
         * 
         */
        public const string s_p_hsCommodityDescription = "https://onerecord.iata.org/ns/cargo/Product#hsCommodityDescription";
        //public final static IRI p_hsCommodityDescription = IRI.create(s_p_hsCommodityDescription);
        /**
         * If no Code provided, name of commodity
         * 
         */
        public const string s_p_hsCommodityName = "https://onerecord.iata.org/ns/cargo/Product#hsCommodityName";
        //public final static IRI p_hsCommodityName = IRI.create(s_p_hsCommodityName);
        /**
         * Reference identifying the type of standard code to be used for the Commodity Classification (Brussels Tariff Nomenclature, EU Harmonized System Code, UN Standard International Trade Classification). Mandatory if the commodity code is more than 6 digits
         * 
         */
        public const string s_p_hsType = "https://onerecord.iata.org/ns/cargo/Product#hsType";
        //public final static IRI p_hsType = IRI.create(s_p_hsType);
        /**
         * Product description
         * 
         */
        public const string s_p_productDescription_A = "https://onerecord.iata.org/ns/cargo/Product#productDescription";
        //public final static IRI p_productDescription_A = IRI.create(s_p_productDescription_A);
        /**
         * Manufacturer's unique product identifier
         * 
         */
        public const string s_p_productIdentifier = "https://onerecord.iata.org/ns/cargo/Product#productIdentifier";
        //public final static IRI p_productIdentifier = IRI.create(s_p_productIdentifier);
        /**
         * Identifies the subsidiary hazard class / division identification containing a numeric field separated by a decimal. There may be 0, 1 or 2 subsidiary risk classes or divisions. If there is more than one, each should be separated by a comma. The subsidiary risk must be shown in parentheses. 
         * 
         */
        public const string s_p_additionalHazardClassificationId = "https://onerecord.iata.org/ns/cargo/ProductDg#additionalHazardClassificationId";
        //public final static IRI p_additionalHazardClassificationId = IRI.create(s_p_additionalHazardClassificationId);
        /**
         * Contains additional information relating to an approval, permission or other specific detail applicable to the commodity (e.g. Dangerous Goods in excepted quantities) 
         * 
         */
        public const string s_p_authorizationInformation = "https://onerecord.iata.org/ns/cargo/ProductDg#authorizationInformation";
        //public final static IRI p_authorizationInformation = IRI.create(s_p_authorizationInformation);
        /**
         * Specifies the reference to the group which identifies the kind of substances and articles that are deemed to be compatible. Mandatory field in case of transport of explosive articles or substances
         * 
         */
        public const string s_p_explosiveCompatibilityGroupCode = "https://onerecord.iata.org/ns/cargo/ProductDg#explosiveCompatibilityGroupCode";
        //public final static IRI p_explosiveCompatibilityGroupCode = IRI.create(s_p_explosiveCompatibilityGroupCode);
        /**
         * Identifies the hazard class / division identification containing a numeric field separated by a decimal
         * 
         */
        public const string s_p_hazardClassificationId = "https://onerecord.iata.org/ns/cargo/ProductDg#hazardClassificationId";
        //public final static IRI p_hazardClassificationId = IRI.create(s_p_hazardClassificationId);
        /**
         * Packing group, If used must reference I, II or III
         * 
         */
        public const string s_p_packagingDangerLevelCode = "https://onerecord.iata.org/ns/cargo/ProductDg#packagingDangerLevelCode";
        //public final static IRI p_packagingDangerLevelCode = IRI.create(s_p_packagingDangerLevelCode);
        /**
         * The packing instruction number applicable to the UN number / proper shipping name entry. A three-numeric value which may be preceded by the letter Y.  Mandatory field for air transport (Air) 
         * 
         */
        public const string s_p_packingInstructionNumber = "https://onerecord.iata.org/ns/cargo/ProductDg#packingInstructionNumber";
        //public final static IRI p_packingInstructionNumber = IRI.create(s_p_packingInstructionNumber);
        /**
         * The name used to describe the particular article or substance as shown in the UN Model Regulations Dangerous Goods List
         * 
         */
        public const string s_p_properShippingName = "https://onerecord.iata.org/ns/cargo/ProductDg#properShippingName";
        //public final static IRI p_properShippingName = IRI.create(s_p_properShippingName);
        /**
         * For Air Mode: Special Provision may show a single, double or triple digit number preceded by the letter A, against appropriate entries in the List of Dangerous Goods
         * 
         */
        public const string s_p_specialProvisionId = "https://onerecord.iata.org/ns/cargo/ProductDg#specialProvisionId";
        //public final static IRI p_specialProvisionId = IRI.create(s_p_specialProvisionId);
        /**
         * This is additional chemical name(s) required for some proper shipping names. When added the technical must be shown in parentheses immediately following the proper shipping name. 
         * 
         */
        public const string s_p_technicalName = "https://onerecord.iata.org/ns/cargo/ProductDg#technicalName";
        //public final static IRI p_technicalName = IRI.create(s_p_technicalName);
        /**
         * Reference identifying the United Nations Dangerous Goods serial number assigned within the UN to substances and articles contained in a list of the dangerous goods most commonly carried. e.g. 1189 - Ethylene glycol monomethyl ether acetate
         * 
         */
        public const string s_p_unNumber = "https://onerecord.iata.org/ns/cargo/ProductDg#unNumber";
        //public final static IRI p_unNumber = IRI.create(s_p_unNumber);
        /**
         * Amount
         * 
         */
        public const string s_p_amount = "https://onerecord.iata.org/ns/cargo/Ranges#amount";
        //public final static IRI p_amount = IRI.create(s_p_amount);
        /**
         * Maximum quantity
         * 
         */
        public const string s_p_maximumQuantity = "https://onerecord.iata.org/ns/cargo/Ranges#maximumQuantity";
        //public final static IRI p_maximumQuantity = IRI.create(s_p_maximumQuantity);
        /**
         * Minimum quantity
         * 
         */
        public const string s_p_minimumQuantity = "https://onerecord.iata.org/ns/cargo/Ranges#minimumQuantity";
        //public final static IRI p_minimumQuantity = IRI.create(s_p_minimumQuantity);
        /**
         * Rate class code e.g. Q. Refer to CXML Code List 1.4 Rate Class Codes
         * 
         */
        public const string s_p_rateClassCode = "https://onerecord.iata.org/ns/cargo/Ranges#rateClassCode";
        //public final static IRI p_rateClassCode = IRI.create(s_p_rateClassCode);
        /**
         * rating type - Refer to CXML Code List 1.44 ULD Charge Codes
         * 
         */
        public const string s_p_ratingType = "https://onerecord.iata.org/ns/cargo/Ranges#ratingType";
        //public final static IRI p_ratingType = IRI.create(s_p_ratingType);
        /**
         * Specific commodity rates linked to commodity
         * 
         */
        public const string s_p_scr = "https://onerecord.iata.org/ns/cargo/Ranges#scr";
        //public final static IRI p_scr = IRI.create(s_p_scr);
        /**
         * Specific commodity code linked to commodity
         * 
         */
        public const string s_p_unitBasis = "https://onerecord.iata.org/ns/cargo/Ranges#unitBasis";
        //public final static IRI p_unitBasis = IRI.create(s_p_unitBasis);
        /**
         * Billing charge identifiers to be used for CASS. Refer to cargo/XML Code List 1.33
         * 
         */
        public const string s_p_billingChargeIdentifier = "https://onerecord.iata.org/ns/cargo/Ratings#billingChargeIdentifier";
        //public final static IRI p_billingChargeIdentifier = IRI.create(s_p_billingChargeIdentifier);
        /**
         * Charge code, refer to cargo/XML Code List 1.1
         * 
         */
        public const string s_p_chargeCode = "https://onerecord.iata.org/ns/cargo/Ratings#chargeCode";
        //public final static IRI p_chargeCode = IRI.create(s_p_chargeCode);
        /**
         * Description of the charge e.g. Airfreight, fuel, etc.
         * 
         */
        public const string s_p_chargeDescription = "https://onerecord.iata.org/ns/cargo/Ratings#chargeDescription";
        //public final static IRI p_chargeDescription = IRI.create(s_p_chargeDescription);
        /**
         * Indicates if charge is prepaid or collect (P, C)
         * 
         */
        public const string s_p_chargePaymentType = "https://onerecord.iata.org/ns/cargo/Ratings#chargePaymentType";
        //public final static IRI p_chargePaymentType = IRI.create(s_p_chargePaymentType);
        /**
         * Type of charge that should match the code expressed in either chargeCode, otherChargeCode or billingChargeIndentifier data properties.
         * 
         */
        public const string s_p_chargeType = "https://onerecord.iata.org/ns/cargo/Ratings#chargeType";
        //public final static IRI p_chargeType = IRI.create(s_p_chargeType);
        /**
         * Entitlement code to define if charges are Due carrier (C) or Due agent (A). Refer to CXML Code List 1.3
         * 
         */
        public const string s_p_entitlement = "https://onerecord.iata.org/ns/cargo/Ratings#entitlement";
        //public final static IRI p_entitlement = IRI.create(s_p_entitlement);
        /**
         * Refer to cargo/XML Code List 1.2 for Other Charges
         * 
         */
        public const string s_p_otherChargeCode = "https://onerecord.iata.org/ns/cargo/Ratings#otherChargeCode";
        //public final static IRI p_otherChargeCode = IRI.create(s_p_otherChargeCode);
        /**
         * Specification of the price e.g. Street, Group, Spot, etc.
         * 
         */
        public const string s_p_priceSpecification = "https://onerecord.iata.org/ns/cargo/Ratings#priceSpecification";
        //public final static IRI p_priceSpecification = IRI.create(s_p_priceSpecification);
        /**
         * Reference of price specifications
         * 
         */
        public const string s_p_priceSpecificationRef = "https://onerecord.iata.org/ns/cargo/Ratings#priceSpecificationRef";
        //public final static IRI p_priceSpecificationRef = IRI.create(s_p_priceSpecificationRef);
        /**
         * Used if there is an applicable quantity to the rate (Usually a Time or a Number)
         * 
         */
        public const string s_p_quantity_A = "https://onerecord.iata.org/ns/cargo/Ratings#quantity";
        //public final static IRI p_quantity_A = IRI.create(s_p_quantity_A);
        /**
         * Used to identify if the Ratings are Face, Published or Actual ratings. Expected values are F, A, C.
         * 
         */
        public const string s_p_ratingsType = "https://onerecord.iata.org/ns/cargo/Ratings#ratingsType";
        //public final static IRI p_ratingsType = IRI.create(s_p_ratingsType);
        /**
         * IATA 3-letter code of the rate combination point
         * 
         */
        public const string s_p_rcp = "https://onerecord.iata.org/ns/cargo/Ratings#rcp";
        //public final static IRI p_rcp = IRI.create(s_p_rcp);
        /**
         * Subtotal of the charge
         * 
         */
        public const string s_p_subTotal = "https://onerecord.iata.org/ns/cargo/Ratings#subTotal";
        //public final static IRI p_subTotal = IRI.create(s_p_subTotal);
        /**
         * Expiry date 4 digits month/year
         * 
         */
        public const string s_p_expiryDate_A = "https://onerecord.iata.org/ns/cargo/RegulatedEntity#expiryDate";
        //public final static IRI p_expiryDate_A = IRI.create(s_p_expiryDate_A);
        /**
         * Party type - e.g. RA - Regulated Agent, KC - Known Consignor, AO - Aircraft Operator, RC - Regulated Carrier
         * 
         */
        public const string s_p_regulatedEntityCategory = "https://onerecord.iata.org/ns/cargo/RegulatedEntity#regulatedEntityCategory";
        //public final static IRI p_regulatedEntityCategory = IRI.create(s_p_regulatedEntityCategory);
        /**
         * Aircraft possibility code
         * 
         */
        public const string s_p_aircraftPossibilityCode = "https://onerecord.iata.org/ns/cargo/Routing#aircraftPossibilityCode";
        //public final static IRI p_aircraftPossibilityCode = IRI.create(s_p_aircraftPossibilityCode);
        /**
         * Latest Arrival date time (requested or proposed)
         * 
         */
        public const string s_p_latestArrivalDateTime = "https://onerecord.iata.org/ns/cargo/Routing#latestArrivalDateTime";
        //public final static IRI p_latestArrivalDateTime = IRI.create(s_p_latestArrivalDateTime);
        /**
         * Maximum number of connections of the transport movement (requested or proposed)
         * 
         */
        public const string s_p_maxConnections = "https://onerecord.iata.org/ns/cargo/Routing#maxConnections";
        //public final static IRI p_maxConnections = IRI.create(s_p_maxConnections);
        /**
         * Indicates interlining (requested or proposed)
         * 
         */
        public const string s_p_onlineInd = "https://onerecord.iata.org/ns/cargo/Routing#onlineInd";
        //public final static IRI p_onlineInd = IRI.create(s_p_onlineInd);
        /**
         * Indicates if RFS (Road Feeder Services) is included (requested or proposed)
         * 
         */
        public const string s_p_rfsInd = "https://onerecord.iata.org/ns/cargo/Routing#rfsInd";
        //public final static IRI p_rfsInd = IRI.create(s_p_rfsInd);
        /**
         * arliest acceptance date time (requested or proposed)
         * 
         */
        public const string s_p_earliestAcceptanceTime_A = "https://onerecord.iata.org/ns/cargo/Schedule#earliestAcceptanceTime";
        //public final static IRI p_earliestAcceptanceTime_A = IRI.create(s_p_earliestAcceptanceTime_A);
        /**
         * Latest Acceptance time as per cargo/IQ definition (requested, proposed or actual)
         * 
         */
        public const string s_p_latestAcceptanceTime_A = "https://onerecord.iata.org/ns/cargo/Schedule#latestAcceptanceTime";
        //public final static IRI p_latestAcceptanceTime_A = IRI.create(s_p_latestAcceptanceTime_A);
        /**
         * Time of availability of the shipment as per cargo/IQ definition
         * 
         */
        public const string s_p_timeOfAvailability_A = "https://onerecord.iata.org/ns/cargo/Schedule#timeOfAvailability";
        //public final static IRI p_timeOfAvailability_A = IRI.create(s_p_timeOfAvailability_A);
        /**
         * Total transit time as per cargo/IQ definition
         * 
         */
        public const string s_p_totalTransitTime_A = "https://onerecord.iata.org/ns/cargo/Schedule#totalTransitTime";
        //public final static IRI p_totalTransitTime_A = IRI.create(s_p_totalTransitTime_A);
        /**
         * Arrival date and time of the leg
         * 
         */
        public const string s_p_arrivalDate = "https://onerecord.iata.org/ns/cargo/ScheduledLegs#arrivalDate";
        //public final static IRI p_arrivalDate = IRI.create(s_p_arrivalDate);
        /**
         * Departure date and time of the leg
         * 
         */
        public const string s_p_departureDate = "https://onerecord.iata.org/ns/cargo/ScheduledLegs#departureDate";
        //public final static IRI p_departureDate = IRI.create(s_p_departureDate);
        /**
         * Sequence number of the leg
         * 
         */
        public const string s_p_sequenceNumber = "https://onerecord.iata.org/ns/cargo/ScheduledLegs#sequenceNumber";
        //public final static IRI p_sequenceNumber = IRI.create(s_p_sequenceNumber);
        /**
         * Transport Id of the leg. E.g. Flight number, truck route identifier, etc.
         * 
         */
        public const string s_p_transportId = "https://onerecord.iata.org/ns/cargo/ScheduledLegs#transportId";
        //public final static IRI p_transportId = IRI.create(s_p_transportId);
        /**
         * Any additional information that may be required by an ICAO Member State
         * 
         */
        public const string s_p_additionalSecurityInformation = "https://onerecord.iata.org/ns/cargo/SecurityDeclaration#additionalSecurityInformation";
        //public final static IRI p_additionalSecurityInformation = IRI.create(s_p_additionalSecurityInformation);
        /**
         * Exemption code - e.g. BIOM- Bio-Medical Samples 
         * SMUS - small undersized shipments MAIL - mail
         * BIOM - bio-medical samples
         * DIPL - diplomatic bags or diplomatic mail
         * LFSM - life-saving materials NUCL - nuclear materials
         * TRNS - transfer or transshipment
         * 
         */
        public const string s_p_groundsForExemption = "https://onerecord.iata.org/ns/cargo/SecurityDeclaration#groundsForExemption";
        //public final static IRI p_groundsForExemption = IRI.create(s_p_groundsForExemption);
        /**
         * Date and time when the security status was issued
         * 
         */
        public const string s_p_issuedOn = "https://onerecord.iata.org/ns/cargo/SecurityDeclaration#issuedOn";
        //public final static IRI p_issuedOn = IRI.create(s_p_issuedOn);
        /**
         * Other methods used to secure the cargo/
         * 
         */
        public const string s_p_otherScreeningMethods = "https://onerecord.iata.org/ns/cargo/SecurityDeclaration#otherScreeningMethods";
        //public final static IRI p_otherScreeningMethods = IRI.create(s_p_otherScreeningMethods);
        /**
         * Screening methods which have been used to secure the cargo/
         * PHS \u2013 Physical Inspection and/or hand search 
         * VCK - Visual check 
         * XRY- X-ray equipment 
         * EDS - Explosive detection system 
         * EDD - Explosive detection dogs
         * ETD - Explosive trace detection equipment - particles or vapor 
         * CMD - cargo/ metal detection
         * AOM - Subjected to any other means: this entry should be followed by free text specifying what other mean was used to secure the cargo/
         * 
         */
        public const string s_p_screeningMethod = "https://onerecord.iata.org/ns/cargo/SecurityDeclaration#screeningMethod";
        //public final static IRI p_screeningMethod = IRI.create(s_p_screeningMethod);
        /**
         * Security status indicator (CXML 1.103) - e.g. SPX- cargo/ Secure for Passenger and All-cargo/ Aircraft 
         * 
         */
        public const string s_p_securityStatus_A = "https://onerecord.iata.org/ns/cargo/SecurityDeclaration#securityStatus";
        //public final static IRI p_securityStatus_A = IRI.create(s_p_securityStatus_A);
        /**
         * Natural language description of the sensor
         * 
         */
        public const string s_p_sensorDescription = "https://onerecord.iata.org/ns/cargo/Sensor#sensorDescription";
        //public final static IRI p_sensorDescription = IRI.create(s_p_sensorDescription);
        /**
         * Name of the sensor defined by the sensor's manufacturer
         * 
         */
        public const string s_p_sensorName = "https://onerecord.iata.org/ns/cargo/Sensor#sensorName";
        //public final static IRI p_sensorName = IRI.create(s_p_sensorName);
        /**
         * Serial number that allows to uniquely identify the sensor
         * 
         */
        public const string s_p_sensorSerialNumber = "https://onerecord.iata.org/ns/cargo/Sensor#sensorSerialNumber";
        //public final static IRI p_sensorSerialNumber = IRI.create(s_p_sensorSerialNumber);
        /**
         * Type of sensor as described in Interactive cargo/ Recommended Practice
         * 
         */
        public const string s_p_sensorType = "https://onerecord.iata.org/ns/cargo/Sensor#sensorType";
        //public final static IRI p_sensorType = IRI.create(s_p_sensorType);
        /**
         * Service request code
         * 
         */
        public const string s_p_code_A = "https://onerecord.iata.org/ns/cargo/ServiceRequest#code";
        //public final static IRI p_code_A = IRI.create(s_p_code_A);
        /**
         * Service request description
         * 
         */
        public const string s_p_serviceRequestDescription = "https://onerecord.iata.org/ns/cargo/ServiceRequest#serviceRequestDescription";
        //public final static IRI p_serviceRequestDescription = IRI.create(s_p_serviceRequestDescription);
        /**
         * Service request statement text
         * 
         */
        public const string s_p_statementText = "https://onerecord.iata.org/ns/cargo/ServiceRequest#statementText";
        //public final static IRI p_statementText = IRI.create(s_p_statementText);
        /**
         * Service request statement type - e.g. Dangerous Goods, Lithium Ion Battery, Live Animal Certificate
         * 
         */
        public const string s_p_statementType = "https://onerecord.iata.org/ns/cargo/ServiceRequest#statementType";
        //public final static IRI p_statementType = IRI.create(s_p_statementType);
        /**
         * he date at which the delivery is supposed to happen. Format is YYYYMMDD.
         * 
         */
        public const string s_p_deliveryDate = "https://onerecord.iata.org/ns/cargo/Shipment#deliveryDate";
        //public final static IRI p_deliveryDate = IRI.create(s_p_deliveryDate);
        /**
         * General goods description
         * 
         */
        public const string s_p_goodsDescription_A = "https://onerecord.iata.org/ns/cargo/Shipment#goodsDescription";
        //public final static IRI p_goodsDescription_A = IRI.create(s_p_goodsDescription_A);
        /**
         * Standard codes as defined by UNCEFACT and ICC that correspond to international rules for the interpretation of the most commonly used trade terms in different countries. UNECE recommendation n. 5 Incoterms 2000.
         * 
         */
        public const string s_p_incoterms = "https://onerecord.iata.org/ns/cargo/Shipment#incoterms";
        //public final static IRI p_incoterms = IRI.create(s_p_incoterms);
        /**
         * payment of Other Charges will be made at origin (prepaid) or at destination (collect)
         * 
         */
        public const string s_p_otherChargesIndicator = "https://onerecord.iata.org/ns/cargo/Shipment#otherChargesIndicator";
        //public final static IRI p_otherChargesIndicator = IRI.create(s_p_otherChargesIndicator);
        /**
         * Total Piece Count
         * 
         */
        public const string s_p_totalPieceCount = "https://onerecord.iata.org/ns/cargo/Shipment#totalPieceCount";
        //public final static IRI p_totalPieceCount = IRI.create(s_p_totalPieceCount);
        /**
         * Total SLAC of all piece groups 
         * 
         */
        public const string s_p_totalSLAC = "https://onerecord.iata.org/ns/cargo/Shipment#totalSLAC";
        //public final static IRI p_totalSLAC = IRI.create(s_p_totalSLAC);
        /**
         * payment for the Weight/Valuation will be made at origin (prepaid) or at destination (collect)
         * 
         */
        public const string s_p_weightValuationIndicator = "https://onerecord.iata.org/ns/cargo/Shipment#weightValuationIndicator";
        //public final static IRI p_weightValuationIndicator = IRI.create(s_p_weightValuationIndicator);
        /**
         * Special handling code following IATA standards. Refer CXML1.16,  e.g. PEP - Fruits and Vegetables
         * 
         */
        public const string s_p_code_A_A = "https://onerecord.iata.org/ns/cargo/SpecialHandling#code";
        //public final static IRI p_code_A_A = IRI.create(s_p_code_A_A);
        /**
         * Special handling text
         * 
         */
        public const string s_p_handlingText = "https://onerecord.iata.org/ns/cargo/SpecialHandling#handlingText";
        //public final static IRI p_handlingText = IRI.create(s_p_handlingText);
        /**
         * Model or make of the vehicle (e.g. A330-300)
         * 
         */
        public const string s_p_vehicleModel = "https://onerecord.iata.org/ns/cargo/TransportMeans#vehicleModel";
        //public final static IRI p_vehicleModel = IRI.create(s_p_vehicleModel);
        /**
         * Vehicle identification - e.g. aircraft registration number
         * 
         */
        public const string s_p_vehicleRegistration = "https://onerecord.iata.org/ns/cargo/TransportMeans#vehicleRegistration";
        //public final static IRI p_vehicleRegistration = IRI.create(s_p_vehicleRegistration);
        /**
         * Size of the vehicle - free text
         * 
         */
        public const string s_p_vehicleSize = "https://onerecord.iata.org/ns/cargo/TransportMeans#vehicleSize";
        //public final static IRI p_vehicleSize = IRI.create(s_p_vehicleSize);
        /**
         * Vehicle or container type. Refer UNECE28, e.g. 4.00.0 - Aircraft, type unknown.For Air refer to IATA Standard Schedules Information Manua in section ATA/IATA Aircraft Types
         * 
         */
        public const string s_p_vehicleType = "https://onerecord.iata.org/ns/cargo/TransportMeans#vehicleType";
        //public final static IRI p_vehicleType = IRI.create(s_p_vehicleType);
        /**
         * e.g. Kerosene, Diesel, SAF, Electricity [renewable], Electricity [non-renewable]
         * 
         */
        public const string s_p_fuelType = "https://onerecord.iata.org/ns/cargo#fuelType";
        //public final static IRI p_fuelType = IRI.create(s_p_fuelType);
        /**
         * Mode of transport code, refer to UNECE Rec. 19
         * https://unece.org/fileadmin/DAM/cefact/recommendations/rec19/rec19_01cf19e.pdf
         * 
         */
        public const string s_p_modeCode = "https://onerecord.iata.org/ns/cargo#modeCode";
        //public final static IRI p_modeCode = IRI.create(s_p_modeCode);
        /**
         * Pre-Carriage, Main-Carriage or On-Carriage
         * 
         */
        public const string s_p_modeQualifier = "https://onerecord.iata.org/ns/cargo#modeQualifier";
        //public final static IRI p_modeQualifier = IRI.create(s_p_modeQualifier);
        /**
         * Seal identifier
         * 
         */
        public const string s_p_seal = "https://onerecord.iata.org/ns/cargo#seal";
        //public final static IRI p_seal = IRI.create(s_p_seal);
        /**
         * Airline flight number, or rail /  truck / maritime line id
         * 
         */
        public const string s_p_transportIdentifier = "https://onerecord.iata.org/ns/cargo#transportIdentifier";
        //public final static IRI p_transportIdentifier = IRI.create(s_p_transportIdentifier);
        /**
         * Free text field to be used for additional details regarding unplanned stops such as technical stops.
         * 
         */
        public const string s_p_unplannedStop = "https://onerecord.iata.org/ns/cargo#unplannedStop";
        //public final static IRI p_unplannedStop = IRI.create(s_p_unplannedStop);
        /**
         * US / ATA Unit Load Device type code e.g. M2
         * 
         */
        public const string s_p_ataDesignator = "https://onerecord.iata.org/ns/cargo/ULD#ataDesignator";
        //public final static IRI p_ataDesignator = IRI.create(s_p_ataDesignator);
        /**
         * Indicates if the ULD is Damaged
         * 
         */
        public const string s_p_damageFlag = "https://onerecord.iata.org/ns/cargo/ULD#damageFlag";
        //public final static IRI p_damageFlag = IRI.create(s_p_damageFlag);
        /**
         * Contains three designator of demurrage code, refer to RP 1654 (BCC, HHH, XXX, ZZZ)
         * 
         */
        public const string s_p_demurrageCode = "https://onerecord.iata.org/ns/cargo/ULD#demurrageCode";
        //public final static IRI p_demurrageCode = IRI.create(s_p_demurrageCode);
        /**
         * ULD height or loading limitation code. Refer CXML Code List 1.47,  e.g. R - ULD Height above 244 centimetres
         * 
         */
        public const string s_p_loadingIndicator = "https://onerecord.iata.org/ns/cargo/ULD#loadingIndicator";
        //public final static IRI p_loadingIndicator = IRI.create(s_p_loadingIndicator);
        /**
         * Number of doors
         * 
         */
        public const string s_p_nbDoor = "https://onerecord.iata.org/ns/cargo/ULD#nbDoor";
        //public final static IRI p_nbDoor = IRI.create(s_p_nbDoor);
        /**
         * Number of fittings
         * 
         */
        public const string s_p_nbFittings = "https://onerecord.iata.org/ns/cargo/ULD#nbFittings";
        //public final static IRI p_nbFittings = IRI.create(s_p_nbFittings);
        /**
         * Number of nets
         * 
         */
        public const string s_p_nbNets = "https://onerecord.iata.org/ns/cargo/ULD#nbNets";
        //public final static IRI p_nbNets = IRI.create(s_p_nbNets);
        /**
         * Number of straps
         * 
         */
        public const string s_p_nbStraps = "https://onerecord.iata.org/ns/cargo/ULD#nbStraps";
        //public final static IRI p_nbStraps = IRI.create(s_p_nbStraps);
        /**
         * Contains two designator codes of ODLN or Operational Damage Limit Notices. ODLN code is used to define type of damage after visually check the serviceability of ULDs section 7, Standard Specifications 40/3 or 40/4 in ULD Regulations
         * 
         */
        public const string s_p_odlnCode = "https://onerecord.iata.org/ns/cargo/ULD#odlnCode";
        //public final static IRI p_odlnCode = IRI.create(s_p_odlnCode);
        /**
         * Owner code of the ULD in aa, an or na format - owner can be an airline or leasing company
         * 
         */
        public const string s_p_ownerCode = "https://onerecord.iata.org/ns/cargo/ULD#ownerCode";
        //public final static IRI p_ownerCode = IRI.create(s_p_ownerCode);
        /**
         * ULD serial number
         * 
         */
        public const string s_p_serialNumber = "https://onerecord.iata.org/ns/cargo/ULD#serialNumber";
        //public final static IRI p_serialNumber = IRI.create(s_p_serialNumber);
        /**
         * Designator of serviceablity condition e.g. SER or DAM 
         * 
         */
        public const string s_p_serviceabilityCode = "https://onerecord.iata.org/ns/cargo/ULD#serviceabilityCode";
        //public final static IRI p_serviceabilityCode = IRI.create(s_p_serviceabilityCode);
        /**
         * Remarks or Supplement Information
         * 
         */
        public const string s_p_uldRemarks = "https://onerecord.iata.org/ns/cargo/ULD#uldRemarks";
        //public final static IRI p_uldRemarks = IRI.create(s_p_uldRemarks);
        /**
         * ULD seal number if applicable
         * 
         */
        public const string s_p_uldSealNumber = "https://onerecord.iata.org/ns/cargo/ULD#uldSealNumber";
        //public final static IRI p_uldSealNumber = IRI.create(s_p_uldSealNumber);
        /**
         * Standard Unit Load Device type code e.g. AKE - Certified Container - Contoured. Refer to IATA ULD Technical Manual
         * 
         */
        public const string s_p_uldTypeCode = "https://onerecord.iata.org/ns/cargo/ULD#uldTypeCode";
        //public final static IRI p_uldTypeCode = IRI.create(s_p_uldTypeCode);
        /**
         * Unit of measurement/ unit of account e.g. CMT - Centimetre,  LTR - Litre (1 DM3), KGM - Kilogram, CHF - Swiss Franc
         * 
         */
        public const string s_p_unit = "https://onerecord.iata.org/ns/cargo/Value#unit";
        //public final static IRI p_unit = IRI.create(s_p_unit);
        /**
         * Value
         * 
         */
        public const string s_p_value_A = "https://onerecord.iata.org/ns/cargo/Value#value";
        //public final static IRI p_value_A = IRI.create(s_p_value_A);
        /**
         * Indicates the details of accounting information. Free text e.g. PAYMENT BY CERTIFIED CHEQUE etc.
         * 
         */
        public const string s_p_accountingInformation = "https://onerecord.iata.org/ns/cargo#accountingInformation";
        //public final static IRI p_accountingInformation = IRI.create(s_p_accountingInformation);
        /**
         * Date upon which the certification is made by the carrier
         * 
         */
        public const string s_p_carrierDeclarationDate = "https://onerecord.iata.org/ns/cargo/Waybill#carrierDeclarationDate";
        //public final static IRI p_carrierDeclarationDate = IRI.create(s_p_carrierDeclarationDate);
        /**
         * Contains the authentication of the Carrier
         * 
         */
        public const string s_p_carrierDeclarationSignature = "https://onerecord.iata.org/ns/cargo/Waybill#carrierDeclarationSignature";
        //public final static IRI p_carrierDeclarationSignature = IRI.create(s_p_carrierDeclarationSignature);
        /**
         * Name of consignor signatory
         * 
         */
        public const string s_p_consignorDeclarationSignature = "https://onerecord.iata.org/ns/cargo/Waybill#consignorDeclarationSignature";
        //public final static IRI p_consignorDeclarationSignature = IRI.create(s_p_consignorDeclarationSignature);
        /**
         * Code indicating the origin of goods for Customs purposes (e.g. For goods in free circulation in the EU) 
         * List to be provided by local authorities
         * 
         */
        public const string s_p_customsOriginCode = "https://onerecord.iata.org/ns/cargo/Waybill#customsOriginCode";
        //public final static IRI p_customsOriginCode = IRI.create(s_p_customsOriginCode);
        /**
         * Charges levied at destination accruing to the last carrier, in destination currency
         * 
         */
        public const string s_p_destinationCharges = "https://onerecord.iata.org/ns/cargo/Waybill#destinationCharges";
        //public final static IRI p_destinationCharges = IRI.create(s_p_destinationCharges);
        /**
         * ISO 3-letter currency code of destination. Refer to ISO 4217
         * 
         */
        public const string s_p_destinationCurrencyCode = "https://onerecord.iata.org/ns/cargo/Waybill#destinationCurrencyCode";
        //public final static IRI p_destinationCurrencyCode = IRI.create(s_p_destinationCurrencyCode);
        /**
         * Conversion rate applied
         * 
         */
        public const string s_p_destinationCurrencyRate = "https://onerecord.iata.org/ns/cargo/Waybill#destinationCurrencyRate";
        //public final static IRI p_destinationCurrencyRate = IRI.create(s_p_destinationCurrencyRate);
        /**
         * The shipper or its Agent may enter the appropriate optional shipping
         * 
         */
        public const string s_p_optionalShippingInfo = "https://onerecord.iata.org/ns/cargo/Waybill#optionalShippingInfo";
        //public final static IRI p_optionalShippingInfo = IRI.create(s_p_optionalShippingInfo);
        /**
         * waybill:optionalShippingRefNo
         * 
         */
        public const string s_p_optionalShippingRefNo = "https://onerecord.iata.org/ns/cargo/Waybill#optionalShippingRefNo";
        //public final static IRI p_optionalShippingRefNo = IRI.create(s_p_optionalShippingRefNo);
        /**
         * ISO alpha 3 Code used to indicate the Origin Currency, refer to ISO 4217 currency codes
         * 
         */
        public const string s_p_originCurrency = "https://onerecord.iata.org/ns/cargo/Waybill#originCurrency";
        //public final static IRI p_originCurrency = IRI.create(s_p_originCurrency);
        /**
         * House or Master Waybill unique identifier
         * 
         */
        public const string s_p_waybillNumber_A_A_A = "https://onerecord.iata.org/ns/cargo/Waybill#waybillNumber";
        //public final static IRI p_waybillNumber_A_A_A = IRI.create(s_p_waybillNumber_A_A_A);
        /**
         * Prefix used for the Waybill Number. Refer to IATA Airlines Codes
         * 
         */
        public const string s_p_waybillPrefix = "https://onerecord.iata.org/ns/cargo/Waybill#waybillPrefix";
        //public final static IRI p_waybillPrefix = IRI.create(s_p_waybillPrefix);
        /**
         * Type of the Waybill: House, Direct or Master
         * 
         */
        public const string s_p_waybillType = "https://onerecord.iata.org/ns/cargo/Waybill#waybillType";
        //public final static IRI p_waybillType = IRI.create(s_p_waybillType);
        public const string s_p_description = "http://purl.org/dc/elements/1.1/description";
        //public final static IRI p_description = IRI.create(s_p_description);
        public const string s_p_title = "http://purl.org/dc/elements/1.1/title";
        //public final static IRI p_title = IRI.create(s_p_title);
        public const string s_p__abstract = "http://purl.org/dc/terms/abstract";
        //public final static IRI p__abstract = IRI.create(s_p__abstract);
        public const string s_p_modified = "http://purl.org/dc/terms/modified";
        //public final static IRI p_modified = IRI.create(s_p_modified);
        public const string s_p_title_A = "http://purl.org/dc/terms/title";
        //public final static IRI p_title_A = IRI.create(s_p_title_A);
        public const string s_p_comment = "http://www.w3.org/2000/01/rdf-schema#comment";
        //public final static IRI p_comment = IRI.create(s_p_comment);
        public const string s_p_label = "http://www.w3.org/2000/01/rdf-schema#label";
        //public final static IRI p_label = IRI.create(s_p_label);
        public const string s_p_deprecated = "http://www.w3.org/2002/07/owl#deprecated";
        //public final static IRI p_deprecated = IRI.create(s_p_deprecated);
        public const string s_p_maxCardinality = "http://www.w3.org/2002/07/owl#maxCardinality";
        //public final static IRI p_maxCardinality = IRI.create(s_p_maxCardinality);
        public const string s_p_minCardinality = "http://www.w3.org/2002/07/owl#minCardinality";
        //public final static IRI p_minCardinality = IRI.create(s_p_minCardinality);
        public const string s_p_versionInfo = "http://www.w3.org/2002/07/owl#versionInfo";
        //public final static IRI p_versionInfo = IRI.create(s_p_versionInfo);

    }

}
