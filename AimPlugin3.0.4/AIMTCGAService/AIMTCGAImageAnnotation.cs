#region License

//L
// 2007 - 2013 Copyright Northwestern University
//
// Distributed under the OSI-approved BSD 3-Clause License.
// See http://ncip.github.com/annotation-and-image-markup/LICENSE.txt for details.
//L

#endregion

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

using DataServiceUtil;

namespace AIMTCGAService
{
	public class AIMTCGAImageAnnotation : AIMTCGAQueryBase
	{
		public string[] getImageAnnotationInfo(AIMQueryParameters queryParameters)
		{
			_queryParameters = queryParameters;
			string[] results = null;
			var result = getImageAnnotationCQLInfo();
			if (result != null && result.Items != null && result.Items.Length > 0)
				results = processCQLObjectResult(result);
			return results;
		}

		public List<aim_dotnet.Annotation> getImageAnnotationInfoList(AIMQueryParameters queryParameters)
		{
			var annoStr = getImageAnnotationInfo(queryParameters);
			if (annoStr == null)
				return null;
			var annotations = new List<aim_dotnet.Annotation>();
			var xmlModel = new aim_dotnet.XmlModel();
			aim_dotnet.ImageAnnotation annoAnnotation;
			foreach (var str in annoStr)
			{
				var ann = xmlModel.ReadAnnotationFromXmlString(str);
				annoAnnotation = ann as aim_dotnet.ImageAnnotation;
				if (annoAnnotation != null)
					annotations.Add(annoAnnotation);

			}
			return annotations;
		}

		public DataTable codeTable(List<aim_dotnet.Annotation> annotations, string aimObjectType)
		{
			var table = new DataTable();
			table.Columns.Add("codeValue");
			table.Columns.Add("codeMeaning");
			table.Columns.Add("codingSchemeDesignator");
			foreach (aim_dotnet.ImageAnnotation annoAnnotation in annotations)
			{
				switch (aimObjectType)
				{
					case "AnatomicEntity":
						foreach (var ae in annoAnnotation.AnatomyEntityCollection)
						{
							var dr = table.NewRow();
							dr["codeValue"] = ae.CodeValue;
							dr["codeMeaning"] = ae.CodeMeaning;
							dr["codingSchemeDesignator"] = ae.CodingSchemeDesignator;
							table.Rows.Add(dr);
						}
						break;
					case "ImagingObservation":
						foreach (var ae in annoAnnotation.ImagingObservationCollection)
						{
							var dr = table.NewRow();
							dr["codeValue"] = ae.CodeValue;
							dr["codeMeaning"] = ae.CodeMeaning;
							dr["codingSchemeDesignator"] = ae.CodingSchemeDesignator;
							table.Rows.Add(dr);
						}
						break;
					default:
						table = null;
						break;
				}
			}
			return table;
		}

		public DataTable patientInfo(List<aim_dotnet.Annotation> annotations)
		{
			var table = new DataTable();
			table.Columns.Add("name");
			table.Columns.Add("patientID");
			table.Columns.Add("birthDate");
			table.Columns.Add("sex");
			if (annotations == null)
				return null;
			foreach (aim_dotnet.ImageAnnotation annoAnnotation in annotations)
			{
				var dr = table.NewRow();
				var person = annoAnnotation.Patient;
				if (person.Name != null)
					dr["name"] = person.Name;
				dr["patientID"] = person.Id;
				if (person.BirthDate != null)
					dr["birthDate"] = person.BirthDate.ToString();
				if (person.Sex != null)
					dr["sex"] = person.Sex;
				table.Rows.Add(dr);
			}
			return table;
		}

		private CQLQueryResults getImageAnnotationCQLInfo()
		{
			object[] obj = null;
			Attribute attrTemp = null;
			Association assoTemp = null;
			var proxy = new AIM3DataServicePortTypeClient();

			proxy.Endpoint.Address = new System.ServiceModel.EndpointAddress(AIMDataServiceSettings.Default.AIMDataServiceUrl);
			var associationList = new ArrayList();
			Association aecAssociation = null;
			foreach (var queryData in _queryParameters.AecQueryParameters)
			{
				var results = new ArrayList();
				if (!queryData.CodeValue.IsEmpty)
					results.Add(CreateAttribute("codeValue", queryData.CodeValue));
				//if (!queryData.CodeMeaning.IsEmpty)
					results.Add(CreateAttribute("codeMeaning", queryData.CodeMeaning));
				if (!queryData.CodingSchemeDesignator.IsEmpty)
					results.Add(CreateAttribute("codingSchemeDesignator", queryData.CodingSchemeDesignator));
				if (!queryData.CodingSchemeVersion.IsEmpty)
					results.Add(CreateAttribute("codingSchemeVersion", queryData.CodingSchemeVersion));
				if (!queryData.Confidence.IsEmpty)
					results.Add(CreateAttribute("annotatorConfidence", queryData.Confidence));
				if (results.Count > 0)
					obj = (object[])results.ToArray(typeof(object));
				if (obj != null && obj.Length > 0)
				{
					Group grpAnnatomicEntityCharacteristic = null;
					if (obj.Length > 1)
					{
						grpAnnatomicEntityCharacteristic = CreateQRAttrAssoGroup.createGroup(obj, LogicalOperator.AND);
						obj = null;
					}
					else
						attrTemp = obj[0] as Attribute;

					aecAssociation = CreateQRAttrAssoGroup.createAssociation("edu.northwestern.radiology.aim.AnatomicEntityCharacteristic", "anatomicEntityCharacteristicCollection", grpAnnatomicEntityCharacteristic, attrTemp, null);
				}
			}

			obj = null;
			if (aecAssociation != null && _queryParameters.AeQueryParameters.Count == 0)
			{
				var queryData = new AimAnatomicEntityQueryData();
				queryData.CodeMeaning = new QueryData(String.Empty, QueryPredicate.LIKE);
				_queryParameters.AeQueryParameters.Add(queryData);
			}
			foreach (var queryData in _queryParameters.AeQueryParameters)
			{
				var results = new ArrayList();
				if (!queryData.CodeValue.IsEmpty)
					results.Add(CreateAttribute("codeValue", queryData.CodeValue));
				//if (!queryData.CodeMeaning.IsEmpty)
					results.Add(CreateAttribute("codeMeaning", queryData.CodeMeaning));
				if (!queryData.CodingSchemeDesignator.IsEmpty)
					results.Add(CreateAttribute("codingSchemeDesignator", queryData.CodingSchemeDesignator));
				if (!queryData.CodingSchemeVersion.IsEmpty)
					results.Add(CreateAttribute("codingSchemeVersion", queryData.CodingSchemeVersion));
				if (!queryData.Confidence.IsEmpty)
					results.Add(CreateAttribute("annotatorConfidence", queryData.Confidence));
				if (aecAssociation != null)
				    results.Add(aecAssociation);
				if (results.Count > 0)
					obj = (object[])results.ToArray(typeof(object));
				if (obj != null && obj.Length > 0)
				{
					Group grpAnnatomicEntity = null;
					if (obj.Length > 1)
					{
						grpAnnatomicEntity = CreateQRAttrAssoGroup.createGroup(obj, LogicalOperator.AND);
						obj = null;
					}
					else
						attrTemp = obj[0] as Attribute;
					associationList.Add(CreateQRAttrAssoGroup.createAssociation("edu.northwestern.radiology.aim.AnatomicEntity", "anatomicEntityCollection", grpAnnatomicEntity, attrTemp, null));
				}
			}

			obj = null;
			Association iocAssociation = null;
			foreach (var queryData in _queryParameters.ImcQueryParameters)
			{
				var results = new ArrayList();
				if (!queryData.CodeValue.IsEmpty)
					results.Add(CreateAttribute("codeValue", queryData.CodeValue));
				if (!queryData.CodeMeaning.IsEmpty)
					results.Add(CreateAttribute("codeMeaning", queryData.CodeMeaning));
				if (!queryData.CodingSchemeDesignator.IsEmpty)
					results.Add(CreateAttribute("codingSchemeDesignator", queryData.CodingSchemeDesignator));
				if (!queryData.CodingSchemeVersion.IsEmpty)
					results.Add(CreateAttribute("codingSchemeVersion", queryData.CodingSchemeVersion));
				if (!queryData.Confidence.IsEmpty)
					results.Add(CreateAttribute("annotatorConfidence", queryData.Confidence));
				if (!queryData.Comment.IsEmpty)
					results.Add(CreateAttribute("comment", queryData.Comment));
				if (results.Count > 0)
					obj = (object[])results.ToArray(typeof(object));
				if (obj != null && obj.Length > 0)
				{
					Group grpImagingObservationCharacteristic = null;
					if (obj.Length > 1)
					{
						grpImagingObservationCharacteristic = CreateQRAttrAssoGroup.createGroup(obj, LogicalOperator.AND);
						obj = null;
					}
					else
						attrTemp = obj[0] as Attribute;

					iocAssociation = CreateQRAttrAssoGroup.createAssociation("edu.northwestern.radiology.aim.ImagingObservationCharacteristic", "imagingObservationCharacteristicCollection", grpImagingObservationCharacteristic, attrTemp, null);
				}
			}

			obj = null;
			if (iocAssociation != null && _queryParameters.ImQueryParameters.Count == 0)
			{
				var queryData = new AimImagingObservationQueryData();
				queryData.CodeMeaning = new QueryData(String.Empty, QueryPredicate.LIKE);
				_queryParameters.ImQueryParameters.Add(queryData);
			}
			foreach (var queryData in _queryParameters.ImQueryParameters)
			{
				var results = new ArrayList();
				if (!queryData.CodeValue.IsEmpty)
					results.Add(CreateAttribute("codeValue", queryData.CodeValue));
				//if (!queryData.CodeMeaning.IsEmpty)
					results.Add(CreateAttribute("codeMeaning", queryData.CodeMeaning));
				if (!queryData.CodingSchemeDesignator.IsEmpty)
					results.Add(CreateAttribute("codingSchemeDesignator", queryData.CodingSchemeDesignator));
				if (!queryData.CodingSchemeVersion.IsEmpty)
					results.Add(CreateAttribute("codingSchemeVersion", queryData.CodingSchemeVersion));
				if (!queryData.Comment.IsEmpty)
					results.Add(CreateAttribute("comment", queryData.Comment));
				if (!queryData.Confidence.IsEmpty)
					results.Add(CreateAttribute("annotatorConfidence", queryData.Confidence));
				if (iocAssociation != null)
					results.Add(iocAssociation);
				if (results.Count > 0)
					obj = (object[])results.ToArray(typeof(object));
				if (obj != null && obj.Length > 0)
				{
					attrTemp = null;
					Group grpImagingObservation = null;
					if (obj.Length > 1)
					{
						grpImagingObservation = CreateQRAttrAssoGroup.createGroup(obj, LogicalOperator.AND);
						obj = null;
					}
					else
						attrTemp = obj[0] as Attribute;
					associationList.Add(CreateQRAttrAssoGroup.createAssociation("edu.northwestern.radiology.aim.ImagingObservation", "imagingObservationCollection", grpImagingObservation, attrTemp, null));
				}
			}

			obj = null;
			foreach (QueryData queryData in _queryParameters.UserParameters)
			{
				var results = new ArrayList();
				if (!queryData.IsEmpty)
				{
					results.Add(CreateAttribute("loginName", queryData));
					results.Add(CreateAttribute("name", queryData));
				}
				if (results.Count > 0)
					obj = (object[])results.ToArray(typeof(Attribute));
				if (obj != null && obj.Length > 0)
				{
					Group grpAnnatomicEntityCharacteristic = null;
					if (obj.Length > 1)
					{
						grpAnnatomicEntityCharacteristic = CreateQRAttrAssoGroup.createGroup(obj, LogicalOperator.OR);
						obj = null;
					}
					else
						attrTemp = obj[0] as Attribute;
					associationList.Add(CreateQRAttrAssoGroup.createAssociation("edu.northwestern.radiology.aim.User", "user", grpAnnatomicEntityCharacteristic, attrTemp, null));
				}
			}
			var resultStudy = new ArrayList();
			Association assoStudy = null;
			obj = null;
			foreach (QueryData queryData in _queryParameters.StudyInstanceUidParameters)
			{
				if (!queryData.IsEmpty)
					resultStudy.Add(CreateAttribute("instanceUID", queryData));
			}
			if (resultStudy.Count > 0)
				obj = (object[])resultStudy.ToArray(typeof(Attribute));
			if (obj != null && obj.Length > 0)
			{
				attrTemp = null;
				Group grpStudy = null;
				if (obj.Length > 1)
				{
					grpStudy = CreateQRAttrAssoGroup.createGroup(obj, LogicalOperator.OR);
					obj = null;
				}
				else
					attrTemp = obj[0] as Attribute;
				assoStudy = CreateQRAttrAssoGroup.createAssociation("edu.northwestern.radiology.aim.ImageStudy", "imageStudy", grpStudy, attrTemp, null);
			}
			if (assoStudy != null)
				associationList.Add(CreateQRAttrAssoGroup.createAssociation("edu.northwestern.radiology.aim.DICOMImageReference", "imageReferenceCollection", null, null, assoStudy));
			obj = null;
			Group grpImageAnnotation = null;
			if (associationList.Count > 0)
				obj = (object[])associationList.ToArray(typeof(Association));
			if (obj != null && obj.Length > 0)
			{
				assoTemp = null;
				if (obj.Length > 1)
				{
					grpImageAnnotation = CreateQRAttrAssoGroup.createGroup(obj, LogicalOperator.AND);
				}
				else
					assoTemp = obj[0] as Association;
			}
			QueryRequestCqlQuery arg = CreateQRAttrAssoGroup.createQueryRequestCqlQuery("edu.northwestern.radiology.aim.ImageAnnotation", null, null, assoTemp, grpImageAnnotation);

			var doc = XMLSerializingDeserializing.Serialize(arg);
			Console.WriteLine(doc.InnerXml);

			CQLQueryResults result;
			try
			{
				result = proxy.query(arg);
			}
			catch (System.Net.WebException ex)
			{
				Console.WriteLine(ex.Message);
				result = null;
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
				result = null;
				throw new GridServicerException("Error querying AIM data service", e);
			}
			return result;
		}
	}
}
