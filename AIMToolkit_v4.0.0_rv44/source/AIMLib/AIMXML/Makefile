include ../Makefile.rules

NAME = AIMXML
DEPLIBS = ../Altova/libAltova.a ../AltovaXML/libAltovaXML.a
SHAREDDEPLIBS = ../Altova/libAltova.so ../AltovaXML/libAltovaXML.so
LIB = lib$(NAME).a
SHAREDLIB = lib$(NAME).so

HDRS = AIMXML-typeinfo.h
HDRS +=	AIMXML.h

HDRS += type_.CAdjudicationObservation.h
HDRS += type_.CAimVersion.h
HDRS += type_.CAlgorithm.h
HDRS += type_.CAnnotationCollection.h
HDRS += type_.CAnnotationEntity.h
HDRS += type_.CAnnotationEntityHasPerformedTaskContextEntityStatement.h
HDRS += type_.CAnnotationEntityHasPlannedTaskContextEntityStatement.h
HDRS += type_.CAnnotationOfAnnotation.h
HDRS += type_.CAnnotationOfAnnotationCollection.h
HDRS += type_.CAnnotationOfAnnotationHasAnnotationOfAnnotationStatement.h
HDRS += type_.CAnnotationOfAnnotationHasAnnotationRoleEntityStatement.h
HDRS += type_.CAnnotationOfAnnotationHasCalculationEntityStatement.h
HDRS += type_.CAnnotationOfAnnotationHasGeneralLesionObservationEntityStatement.h
HDRS += type_.CAnnotationOfAnnotationHasImageAnnotationStatement.h
HDRS += type_.CAnnotationOfAnnotationHasImagingObservationEntityStatement.h
HDRS += type_.CAnnotationOfAnnotationHasImagingPhysicalEntityStatement.h
HDRS += type_.CAnnotationOfAnnotationHasInferenceEntityStatement.h
HDRS += type_.CAnnotationOfAnnotationHasTimePointLesionObservationEntityStatement.h
HDRS += type_.CAnnotationOfAnnotationIsComparedWithAnnotationOfAnnotationStatement.h
HDRS += type_.CAnnotationOfAnnotationIsComparedWithImageAnnotationStatement.h
HDRS += type_.CAnnotationOfAnnotationStatement.h
HDRS += type_.CAnnotationRoleEntity.h
HDRS += type_.CAnnotationStatement.h
HDRS += type_.CAuditTrail.h
HDRS += type_.CCalculationData.h
HDRS += type_.CCalculationEntity.h
HDRS += type_.CCalculationEntityIsComparedWithCalculationEntityStatement.h
HDRS += type_.CCalculationEntityReferencesCalculationEntityStatement.h
HDRS += type_.CCalculationEntityUsesCalculationEntityStatement.h
HDRS += type_.CCalculationResult.h
HDRS += type_.CCalculationResultIdentifier.h
HDRS += type_.CCharacteristicQuantification.h
HDRS += type_.CCompactCalculationResult.h
HDRS += type_.CComparisonOperator.h
HDRS += type_.CCoordinate.h
HDRS += type_.CDicomImageReferenceEntity.h
HDRS += type_.CDicomImageReferenceEntityHasCalculationEntityStatement.h
HDRS += type_.CDicomImageReferenceEntityHasImagingObservationEntityStatement.h
HDRS += type_.CDicomImageReferenceEntityHasImagingPhysicalEntityStatement.h
HDRS += type_.CDicomSegmentationEntity.h
HDRS += type_.CDicomSegmentationEntityHasImagingObservationEntityStatement.h
HDRS += type_.CDimension.h
HDRS += type_.CEntity.h
HDRS += type_.CEquipment.h
HDRS += type_.CExtendedCalculationResult.h
HDRS += type_.CGeneralImage.h
HDRS += type_.CGeneralLesionObservationEntity.h
HDRS += type_.CGeneralLesionObservationEntityHasImagingPhysicalEntityStatement.h
HDRS += type_.CGeometricShapeEntity.h
HDRS += type_.CImage.h
HDRS += type_.CImageAnnotation.h
HDRS += type_.CImageAnnotationCollection.h
HDRS += type_.CImageAnnotationHasAnnotationRoleEntityStatement.h
HDRS += type_.CImageAnnotationHasCalculationEntityStatement.h
HDRS += type_.CImageAnnotationHasChildImageAnnotationStatement.h
HDRS += type_.CImageAnnotationHasDicomImageReferenceEntityStatement.h
HDRS += type_.CImageAnnotationHasDicomSegmentationEntityStatement.h
HDRS += type_.CImageAnnotationHasGeneralLesionObservationEntityStatement.h
HDRS += type_.CImageAnnotationHasImagingObservationEntityStatement.h
HDRS += type_.CImageAnnotationHasImagingPhysicalEntityStatement.h
HDRS += type_.CImageAnnotationHasInferenceEntityStatement.h
HDRS += type_.CImageAnnotationHasTextAnnotationEntityStatement.h
HDRS += type_.CImageAnnotationHasThreeDimensionGeometricShapeEntityStatement.h
HDRS += type_.CImageAnnotationHasTimePointLesionObservationEntityStatement.h
HDRS += type_.CImageAnnotationHasTwoDimensionGeometricShapeEntityStatement.h
HDRS += type_.CImageAnnotationHasUriImageReferenceEntityStatement.h
HDRS += type_.CImageAnnotationIsComparedWithAnnotationOfAnnotationStatement.h
HDRS += type_.CImageAnnotationIsComparedWithImageAnnotationStatement.h
HDRS += type_.CImageAnnotationStatement.h
HDRS += type_.CImagePlane.h
HDRS += type_.CImageReferenceEntity.h
HDRS += type_.CImageSeries.h
HDRS += type_.CImageStudy.h
HDRS += type_.CImagingObservationCharacteristic.h
HDRS += type_.CImagingObservationEntity.h
HDRS += type_.CImagingObservationEntityHasCalculationEntityStatement.h
HDRS += type_.CImagingObservationEntityIsFoundInImagingPhysicalEntityStatement.h
HDRS += type_.CImagingObservationEntityIsIdentifiedByTextAnnotationEntityStatement.h
HDRS += type_.CImagingObservationEntityIsIdentifiedByThreeDimensionGeometricShapeEntityStatement.h
HDRS += type_.CImagingObservationEntityIsIdentifiedByTwoDimensionGeometricShapeEntityStatement.h
HDRS += type_.CImagingPhysicalEntity.h
HDRS += type_.CImagingPhysicalEntityCharacteristic.h
HDRS += type_.CImagingPhysicalEntityHasCalculationEntityStatement.h
HDRS += type_.CImagingPhysicalEntityHasImagingObservationEntityStatement.h
HDRS += type_.CImagingPhysicalEntityHasTextAnnotationEntityStatement.h
HDRS += type_.CImagingPhysicalEntityHasThreeDimensionGeometricShapeEntityStatement.h
HDRS += type_.CImagingPhysicalEntityHasTwoDimensionGeometricShapeEntityStatement.h
HDRS += type_.CInferenceEntity.h
HDRS += type_.CInterval.h
HDRS += type_.CLesionObservationEntity.h
HDRS += type_.CMarkupEntity.h
HDRS += type_.CNonQuantifiable.h
HDRS += type_.CNumerical.h
HDRS += type_.CParameter.h
HDRS += type_.CPerson.h
HDRS += type_.CQuantile.h
HDRS += type_.CReferencedDicomObject.h
HDRS += type_.CScale.h
HDRS += type_.CScaleType.h
HDRS += type_.CSegmentationEntity.h
HDRS += type_.CTaskContextEntity.h
HDRS += type_.CTextAnnotationEntity.h
HDRS += type_.CThreeDimensionEllipse.h
HDRS += type_.CThreeDimensionEllipsoid.h
HDRS += type_.CThreeDimensionGeometricShapeEntity.h
HDRS += type_.CThreeDimensionGeometricShapeEntityExcludesThreeDimensionGeometricShapeEntityStatement.h
HDRS += type_.CThreeDimensionGeometricShapeEntityIsComprisedOfThreeDimensionGeometricShapeEntityStatement.h
HDRS += type_.CThreeDimensionMultiPoint.h
HDRS += type_.CThreeDimensionPoint.h
HDRS += type_.CThreeDimensionPolygon.h
HDRS += type_.CThreeDimensionPolyline.h
HDRS += type_.CThreeDimensionSpatialCoordinate.h
HDRS += type_.CTimePointLesionObservationEntity.h
HDRS += type_.CTimePointLesionObservationEntityHasImagingPhysicalEntityStatement.h
HDRS += type_.CTwoDimensionCircle.h
HDRS += type_.CTwoDimensionEllipse.h
HDRS += type_.CTwoDimensionGeometricShapeEntity.h
HDRS += type_.CTwoDimensionGeometricShapeEntityExcludesTwoDimensionGeometricShapeEntityStatement.h
HDRS += type_.CTwoDimensionGeometricShapeEntityIsComprisedOfTwoDimensionGeometricShapeEntityStatement.h
HDRS += type_.CTwoDimensionMultiPoint.h
HDRS += type_.CTwoDimensionPoint.h
HDRS += type_.CTwoDimensionPolyline.h
HDRS += type_.CTwoDimensionSpatialCoordinate.h
HDRS += type_.CUriImageReferenceEntity.h
HDRS += type_.CUriImageReferenceEntityHasCalculationEntityStatement.h
HDRS += type_.CUriImageReferenceEntityHasImagingObservationEntityStatement.h
HDRS += type_.CUriImageReferenceEntityHasImagingPhysicalEntityStatement.h
HDRS += type_.CUser.h
HDRS += type_.CAIMXML.h
HDRS += type_.CbrType.h
HDRS += type_.CcaptionType.h
HDRS += type_.ClinkHtmlType.h
HDRS += type_.CfootnoteType.h
HDRS += type_.CfootnoteRefType.h
HDRS += type_.CcolType.h
HDRS += type_.CalignType.h
HDRS += type_.CvalignType.h
HDRS += type_.CcolgroupType.h
HDRS += type_.CalignType2.h
HDRS += type_.CvalignType2.h
HDRS += type_.CcontentType.h
HDRS += type_.CrevisedType.h
HDRS += type_.CrenderMultiMediaType.h
HDRS += type_.CitemType.h
HDRS += type_.CparagraphType.h
HDRS += type_.ClistType.h
HDRS += type_.CtableType.h
HDRS += type_.CtbodyType.h
HDRS += type_.CalignType3.h
HDRS += type_.CvalignType3.h
HDRS += type_.CtrType.h
HDRS += type_.CtdType.h
HDRS += type_.CscopeType.h
HDRS += type_.CalignType4.h
HDRS += type_.CvalignType4.h
HDRS += type_.CtfootType.h
HDRS += type_.CalignType5.h
HDRS += type_.CvalignType5.h
HDRS += type_.CthType.h
HDRS += type_.CscopeType2.h
HDRS += type_.CalignType6.h
HDRS += type_.CvalignType6.h
HDRS += type_.CtheadType.h
HDRS += type_.CalignType7.h
HDRS += type_.CvalignType7.h
HDRS += type_.CparameterCollectionType.h
HDRS += type_.CauditTrailCollectionType.h
HDRS += type_.CimagingPhysicalEntityCollectionType.h
HDRS += type_.CcalculationEntityCollectionType.h
HDRS += type_.CinferenceEntityCollectionType.h
HDRS += type_.CannotationRoleEntityCollectionType.h
HDRS += type_.ClesionObservationEntityCollectionType.h
HDRS += type_.CimagingObservationEntityCollectionType.h
HDRS += type_.CtaskContextEntityCollectionType.h
HDRS += type_.CannotationOfAnnotationStatementCollectionType.h
HDRS += type_.CannotationOfAnnotationsType.h
HDRS += type_.CcoordinateCollectionType.h
HDRS += type_.CcalculationResultCollectionType.h
HDRS += type_.CdimensionCollectionType.h
HDRS += type_.CcalculationDataCollectionType.h
HDRS += type_.CsegmentationEntityCollectionType.h
HDRS += type_.CmarkupEntityCollectionType.h
HDRS += type_.CimageAnnotationStatementCollectionType.h
HDRS += type_.CimageReferenceEntityCollectionType.h
HDRS += type_.CimageAnnotationsType.h
HDRS += type_.CimageCollectionType.h
HDRS += type_.CreferencedDicomObjectCollectionType.h
HDRS += type_.CcharacteristicQuantificationCollectionType.h
HDRS += type_.CimagingObservationCharacteristicCollectionType.h
HDRS += type_.CimagingPhysicalEntityCharacteristicCollectionType.h
HDRS += type_.CimagingObservationCharacteristicCollectionType2.h
HDRS += type_.CcharacteristicQuantificationCollectionType2.h
HDRS += type_.CtaskContextEntityCollectionType2.h
HDRS += type_.CthreeDimensionSpatialCoordinateCollectionType.h
HDRS += type_.CtwoDimensionSpatialCoordinateCollectionType.h
HDRS += type_.ClistTypeType.h
HDRS += type_.CframeType.h
HDRS += type_.CrulesType.h
HDRS += type_.CalignType8.h
HDRS += type_.CvalignType8.h
HDRS += type_xs.CENTITIES.h
HDRS += type_xs.CENTITY.h
HDRS += type_xs.CID.h
HDRS += type_xs.CIDREF.h
HDRS += type_xs.CIDREFS.h
HDRS += type_xs.CNCName.h
HDRS += type_xs.CNMTOKEN.h
HDRS += type_xs.CNMTOKENS.h
HDRS += type_xs.CNOTATION.h
HDRS += type_xs.CName.h
HDRS += type_xs.CQName.h
HDRS += type_xs.CanySimpleType.h
HDRS += type_xs.CanyType.h
HDRS += type_xs.CanyURI.h
HDRS += type_xs.Cboolean.h
HDRS += type_xs.Cbyte.h
HDRS += type_xs.Cdate.h
HDRS += type_xs.CdateTime.h
HDRS += type_xs.Cdecimal.h
HDRS += type_xs.Cdouble.h
HDRS += type_xs.Cduration.h
HDRS += type_xs.Cfloat.h
HDRS += type_xs.CgDay.h
HDRS += type_xs.CgMonth.h
HDRS += type_xs.CgMonthDay.h
HDRS += type_xs.CgYear.h
HDRS += type_xs.CgYearMonth.h
HDRS += type_xs.ChexBinary.h
HDRS += type_xs.Cint.h
HDRS += type_xs.Cinteger.h
HDRS += type_xs.Clanguage.h
HDRS += type_xs.Clong.h
HDRS += type_xs.CnegativeInteger.h
HDRS += type_xs.CnonNegativeInteger.h
HDRS += type_xs.CnonPositiveInteger.h
HDRS += type_xs.CnormalizedString.h
HDRS += type_xs.CpositiveInteger.h
HDRS += type_xs.Cshort.h
HDRS += type_xs.Ctime.h
HDRS += type_xs.Ctoken.h
HDRS += type_xs.CunsignedByte.h
HDRS += type_xs.CunsignedInt.h
HDRS += type_xs.CunsignedLong.h
HDRS += type_xs.CunsignedShort.h
HDRS += type_xs.CstringType.h
HDRS += type_xs.Cbase64BinaryType.h
HDRS += type_iso.CAD.h
HDRS += type_iso.CADXP.h
HDRS += type_iso.CANY.h
HDRS += type_iso.CAddressPartType.h
HDRS += type_iso.CBAG_AD.h
HDRS += type_iso.CBAG_BL.h
HDRS += type_iso.CBAG_BL_NonNull.h
HDRS += type_iso.CBAG_CD.h
HDRS += type_iso.CBAG_CD_CE.h
HDRS += type_iso.CBAG_CD_CE_None.h
HDRS += type_iso.CBAG_CD_CV.h
HDRS += type_iso.CBAG_CO.h
HDRS += type_iso.CBAG_CS.h
HDRS += type_iso.CBAG_ED.h
HDRS += type_iso.CBAG_ED_Doc.h
HDRS += type_iso.CBAG_ED_Doc_Inline.h
HDRS += type_iso.CBAG_ED_Doc_Ref.h
HDRS += type_iso.CBAG_ED_Image.h
HDRS += type_iso.CBAG_ED_Narrative.h
HDRS += type_iso.CBAG_ED_Signature.h
HDRS += type_iso.CBAG_ED_Text.h
HDRS += type_iso.CBAG_EN.h
HDRS += type_iso.CBAG_EN_ON.h
HDRS += type_iso.CBAG_EN_PN.h
HDRS += type_iso.CBAG_EN_TN.h
HDRS += type_iso.CBAG_II.h
HDRS += type_iso.CBAG_INT.h
HDRS += type_iso.CBAG_INT_NonNeg.h
HDRS += type_iso.CBAG_INT_Positive.h
HDRS += type_iso.CBAG_MO.h
HDRS += type_iso.CBAG_PQ.h
HDRS += type_iso.CBAG_PQ_Time.h
HDRS += type_iso.CBAG_REAL.h
HDRS += type_iso.CBAG_RTO.h
HDRS += type_iso.CBAG_SC.h
HDRS += type_iso.CBAG_SC_NT.h
HDRS += type_iso.CBAG_ST.h
HDRS += type_iso.CBAG_ST_NT.h
HDRS += type_iso.CBAG_TEL.h
HDRS += type_iso.CBAG_TEL_Email.h
HDRS += type_iso.CBAG_TEL_Person.h
HDRS += type_iso.CBAG_TEL_Phone.h
HDRS += type_iso.CBAG_TEL_Url.h
HDRS += type_iso.CBAG_TS.h
HDRS += type_iso.CBAG_TS_Birth.h
HDRS += type_iso.CBAG_TS_Date.h
HDRS += type_iso.CBAG_TS_Date_Full.h
HDRS += type_iso.CBAG_TS_DateTime.h
HDRS += type_iso.CBAG_TS_DateTime_Full.h
HDRS += type_iso.CBL.h
HDRS += type_iso.CBL_NonNull.h
HDRS += type_iso.CCD.h
HDRS += type_iso.CCD_CE.h
HDRS += type_iso.CCD_CE_None.h
HDRS += type_iso.CCD_CV.h
HDRS += type_iso.CCDGroup.h
HDRS += type_iso.CCO.h
HDRS += type_iso.CCOLL_AD.h
HDRS += type_iso.CCOLL_BL.h
HDRS += type_iso.CCOLL_BL_NonNull.h
HDRS += type_iso.CCOLL_CD.h
HDRS += type_iso.CCOLL_CD_CE.h
HDRS += type_iso.CCOLL_CD_CE_None.h
HDRS += type_iso.CCOLL_CD_CV.h
HDRS += type_iso.CCOLL_CO.h
HDRS += type_iso.CCOLL_CS.h
HDRS += type_iso.CCOLL_ED.h
HDRS += type_iso.CCOLL_ED_Doc.h
HDRS += type_iso.CCOLL_ED_Doc_Inline.h
HDRS += type_iso.CCOLL_ED_Doc_Ref.h
HDRS += type_iso.CCOLL_ED_Image.h
HDRS += type_iso.CCOLL_ED_Narrative.h
HDRS += type_iso.CCOLL_ED_Signature.h
HDRS += type_iso.CCOLL_ED_Text.h
HDRS += type_iso.CCOLL_EN.h
HDRS += type_iso.CCOLL_EN_ON.h
HDRS += type_iso.CCOLL_EN_PN.h
HDRS += type_iso.CCOLL_EN_TN.h
HDRS += type_iso.CCOLL_II.h
HDRS += type_iso.CCOLL_INT.h
HDRS += type_iso.CCOLL_INT_NonNeg.h
HDRS += type_iso.CCOLL_INT_Positive.h
HDRS += type_iso.CCOLL_MO.h
HDRS += type_iso.CCOLL_PQ.h
HDRS += type_iso.CCOLL_PQ_Time.h
HDRS += type_iso.CCOLL_REAL.h
HDRS += type_iso.CCOLL_RTO.h
HDRS += type_iso.CCOLL_SC.h
HDRS += type_iso.CCOLL_SC_NT.h
HDRS += type_iso.CCOLL_ST.h
HDRS += type_iso.CCOLL_ST_NT.h
HDRS += type_iso.CCOLL_TEL.h
HDRS += type_iso.CCOLL_TEL_Email.h
HDRS += type_iso.CCOLL_TEL_Person.h
HDRS += type_iso.CCOLL_TEL_Phone.h
HDRS += type_iso.CCOLL_TEL_Url.h
HDRS += type_iso.CCOLL_TS.h
HDRS += type_iso.CCOLL_TS_Birth.h
HDRS += type_iso.CCOLL_TS_Date.h
HDRS += type_iso.CCOLL_TS_Date_Full.h
HDRS += type_iso.CCOLL_TS_DateTime.h
HDRS += type_iso.CCOLL_TS_DateTime_Full.h
HDRS += type_iso.CCR.h
HDRS += type_iso.CCS.h
HDRS += type_iso.CCalendarCycle.h
HDRS += type_iso.CCode.h
HDRS += type_iso.CCodingRationale.h
HDRS += type_iso.CCompression.h
HDRS += type_iso.CDSET_AD.h
HDRS += type_iso.CDSET_BL.h
HDRS += type_iso.CDSET_BL_NonNull.h
HDRS += type_iso.CDSET_CD.h
HDRS += type_iso.CDSET_CD_CE.h
HDRS += type_iso.CDSET_CD_CE_None.h
HDRS += type_iso.CDSET_CD_CV.h
HDRS += type_iso.CDSET_CO.h
HDRS += type_iso.CDSET_CS.h
HDRS += type_iso.CDSET_ED.h
HDRS += type_iso.CDSET_ED_Doc.h
HDRS += type_iso.CDSET_ED_Doc_Inline.h
HDRS += type_iso.CDSET_ED_Doc_Ref.h
HDRS += type_iso.CDSET_ED_Image.h
HDRS += type_iso.CDSET_ED_Narrative.h
HDRS += type_iso.CDSET_ED_Signature.h
HDRS += type_iso.CDSET_ED_Text.h
HDRS += type_iso.CDSET_EN.h
HDRS += type_iso.CDSET_EN_ON.h
HDRS += type_iso.CDSET_EN_PN.h
HDRS += type_iso.CDSET_EN_TN.h
HDRS += type_iso.CDSET_II.h
HDRS += type_iso.CDSET_INT.h
HDRS += type_iso.CDSET_INT_NonNeg.h
HDRS += type_iso.CDSET_INT_Positive.h
HDRS += type_iso.CDSET_MO.h
HDRS += type_iso.CDSET_PQ.h
HDRS += type_iso.CDSET_PQ_Time.h
HDRS += type_iso.CDSET_REAL.h
HDRS += type_iso.CDSET_RTO.h
HDRS += type_iso.CDSET_SC.h
HDRS += type_iso.CDSET_SC_NT.h
HDRS += type_iso.CDSET_ST.h
HDRS += type_iso.CDSET_ST_NT.h
HDRS += type_iso.CDSET_TEL.h
HDRS += type_iso.CDSET_TEL_Email.h
HDRS += type_iso.CDSET_TEL_Person.h
HDRS += type_iso.CDSET_TEL_Phone.h
HDRS += type_iso.CDSET_TEL_Url.h
HDRS += type_iso.CDSET_TS.h
HDRS += type_iso.CDSET_TS_Birth.h
HDRS += type_iso.CDSET_TS_Date.h
HDRS += type_iso.CDSET_TS_Date_Full.h
HDRS += type_iso.CDSET_TS_DateTime.h
HDRS += type_iso.CDSET_TS_DateTime_Full.h
HDRS += type_iso.CED.h
HDRS += type_iso.CED_Doc.h
HDRS += type_iso.CED_Doc_Inline.h
HDRS += type_iso.CED_Doc_Ref.h
HDRS += type_iso.CED_Image.h
HDRS += type_iso.CED_Narrative.h
HDRS += type_iso.CED_Signature.h
HDRS += type_iso.CED_Text.h
HDRS += type_iso.CEIVL_TS.h
HDRS += type_iso.CEIVL_TS_Birth.h
HDRS += type_iso.CEIVL_TS_Date.h
HDRS += type_iso.CEIVL_TS_Date_Full.h
HDRS += type_iso.CEIVL_TS_DateTime.h
HDRS += type_iso.CEIVL_TS_DateTime_Full.h
HDRS += type_iso.CEN.h
HDRS += type_iso.CEN_ON.h
HDRS += type_iso.CEN_PN.h
HDRS += type_iso.CEN_TN.h
HDRS += type_iso.CENXP.h
HDRS += type_iso.CEntityNamePartQualifier.h
HDRS += type_iso.CEntityNamePartType.h
HDRS += type_iso.CEntityNameUse.h
HDRS += type_iso.CGLIST_CO.h
HDRS += type_iso.CGLIST_INT.h
HDRS += type_iso.CGLIST_INT_NonNeg.h
HDRS += type_iso.CGLIST_INT_Positive.h
HDRS += type_iso.CGLIST_MO.h
HDRS += type_iso.CGLIST_PQ.h
HDRS += type_iso.CGLIST_PQ_Time.h
HDRS += type_iso.CGLIST_REAL.h
HDRS += type_iso.CGLIST_RTO.h
HDRS += type_iso.CGLIST_TS.h
HDRS += type_iso.CGLIST_TS_Birth.h
HDRS += type_iso.CGLIST_TS_Date.h
HDRS += type_iso.CGLIST_TS_Date_Full.h
HDRS += type_iso.CGLIST_TS_DateTime.h
HDRS += type_iso.CGLIST_TS_DateTime_Full.h
HDRS += type_iso.CHIST_AD.h
HDRS += type_iso.CHIST_BL.h
HDRS += type_iso.CHIST_BL_NonNull.h
HDRS += type_iso.CHIST_CD.h
HDRS += type_iso.CHIST_CD_CE.h
HDRS += type_iso.CHIST_CD_CE_None.h
HDRS += type_iso.CHIST_CD_CV.h
HDRS += type_iso.CHIST_CO.h
HDRS += type_iso.CHIST_CS.h
HDRS += type_iso.CHIST_ED.h
HDRS += type_iso.CHIST_ED_Doc.h
HDRS += type_iso.CHIST_ED_Doc_Inline.h
HDRS += type_iso.CHIST_ED_Doc_Ref.h
HDRS += type_iso.CHIST_ED_Image.h
HDRS += type_iso.CHIST_ED_Narrative.h
HDRS += type_iso.CHIST_ED_Signature.h
HDRS += type_iso.CHIST_ED_Text.h
HDRS += type_iso.CHIST_EN.h
HDRS += type_iso.CHIST_EN_ON.h
HDRS += type_iso.CHIST_EN_PN.h
HDRS += type_iso.CHIST_EN_TN.h
HDRS += type_iso.CHIST_II.h
HDRS += type_iso.CHIST_INT.h
HDRS += type_iso.CHIST_INT_NonNeg.h
HDRS += type_iso.CHIST_INT_Positive.h
HDRS += type_iso.CHIST_MO.h
HDRS += type_iso.CHIST_PQ.h
HDRS += type_iso.CHIST_PQ_Time.h
HDRS += type_iso.CHIST_REAL.h
HDRS += type_iso.CHIST_RTO.h
HDRS += type_iso.CHIST_SC.h
HDRS += type_iso.CHIST_SC_NT.h
HDRS += type_iso.CHIST_ST.h
HDRS += type_iso.CHIST_ST_NT.h
HDRS += type_iso.CHIST_TEL.h
HDRS += type_iso.CHIST_TEL_Email.h
HDRS += type_iso.CHIST_TEL_Person.h
HDRS += type_iso.CHIST_TEL_Phone.h
HDRS += type_iso.CHIST_TEL_Url.h
HDRS += type_iso.CHIST_TS.h
HDRS += type_iso.CHIST_TS_Birth.h
HDRS += type_iso.CHIST_TS_Date.h
HDRS += type_iso.CHIST_TS_Date_Full.h
HDRS += type_iso.CHIST_TS_DateTime.h
HDRS += type_iso.CHIST_TS_DateTime_Full.h
HDRS += type_iso.CHXIT.h
HDRS += type_iso.CII.h
HDRS += type_iso.CINT.h
HDRS += type_iso.CINT_NonNeg.h
HDRS += type_iso.CINT_Positive.h
HDRS += type_iso.CIVL_High_CO.h
HDRS += type_iso.CIVL_High_INT.h
HDRS += type_iso.CIVL_High_INT_NonNeg.h
HDRS += type_iso.CIVL_High_INT_Positive.h
HDRS += type_iso.CIVL_High_MO.h
HDRS += type_iso.CIVL_High_PQ.h
HDRS += type_iso.CIVL_High_PQ_Time.h
HDRS += type_iso.CIVL_High_REAL.h
HDRS += type_iso.CIVL_High_RTO.h
HDRS += type_iso.CIVL_High_TS.h
HDRS += type_iso.CIVL_High_TS_Birth.h
HDRS += type_iso.CIVL_High_TS_Date.h
HDRS += type_iso.CIVL_High_TS_Date_Full.h
HDRS += type_iso.CIVL_High_TS_DateTime.h
HDRS += type_iso.CIVL_High_TS_DateTime_Full.h
HDRS += type_iso.CIVL_Low_CO.h
HDRS += type_iso.CIVL_Low_INT.h
HDRS += type_iso.CIVL_Low_INT_NonNeg.h
HDRS += type_iso.CIVL_Low_INT_Positive.h
HDRS += type_iso.CIVL_Low_MO.h
HDRS += type_iso.CIVL_Low_PQ.h
HDRS += type_iso.CIVL_Low_PQ_Time.h
HDRS += type_iso.CIVL_Low_REAL.h
HDRS += type_iso.CIVL_Low_RTO.h
HDRS += type_iso.CIVL_Low_TS.h
HDRS += type_iso.CIVL_Low_TS_Birth.h
HDRS += type_iso.CIVL_Low_TS_Date.h
HDRS += type_iso.CIVL_Low_TS_Date_Full.h
HDRS += type_iso.CIVL_Low_TS_DateTime.h
HDRS += type_iso.CIVL_Low_TS_DateTime_Full.h
HDRS += type_iso.CIVL_Width_CO.h
HDRS += type_iso.CIVL_Width_INT.h
HDRS += type_iso.CIVL_Width_INT_NonNeg.h
HDRS += type_iso.CIVL_Width_INT_Positive.h
HDRS += type_iso.CIVL_Width_MO.h
HDRS += type_iso.CIVL_Width_PQ.h
HDRS += type_iso.CIVL_Width_PQ_Time.h
HDRS += type_iso.CIVL_Width_REAL.h
HDRS += type_iso.CIVL_Width_RTO.h
HDRS += type_iso.CIVL_Width_TS.h
HDRS += type_iso.CIVL_Width_TS_Birth.h
HDRS += type_iso.CIVL_Width_TS_Date.h
HDRS += type_iso.CIVL_Width_TS_Date_Full.h
HDRS += type_iso.CIVL_Width_TS_DateTime.h
HDRS += type_iso.CIVL_Width_TS_DateTime_Full.h
HDRS += type_iso.CIVL_CO.h
HDRS += type_iso.CIVL_INT.h
HDRS += type_iso.CIVL_INT_NonNeg.h
HDRS += type_iso.CIVL_INT_Positive.h
HDRS += type_iso.CIVL_MO.h
HDRS += type_iso.CIVL_PQ.h
HDRS += type_iso.CIVL_PQ_Time.h
HDRS += type_iso.CIVL_REAL.h
HDRS += type_iso.CIVL_RTO.h
HDRS += type_iso.CIVL_TS.h
HDRS += type_iso.CIVL_TS_Birth.h
HDRS += type_iso.CIVL_TS_Date.h
HDRS += type_iso.CIVL_TS_Date_Full.h
HDRS += type_iso.CIVL_TS_DateTime.h
HDRS += type_iso.CIVL_TS_DateTime_Full.h
HDRS += type_iso.CIdentifierReliability.h
HDRS += type_iso.CIdentifierScope.h
HDRS += type_iso.CIntegrityCheckAlgorithm.h
HDRS += type_iso.CLIST_AD.h
HDRS += type_iso.CLIST_BL.h
HDRS += type_iso.CLIST_BL_NonNull.h
HDRS += type_iso.CLIST_CD.h
HDRS += type_iso.CLIST_CD_CE.h
HDRS += type_iso.CLIST_CD_CE_None.h
HDRS += type_iso.CLIST_CD_CV.h
HDRS += type_iso.CLIST_CO.h
HDRS += type_iso.CLIST_CS.h
HDRS += type_iso.CLIST_ED.h
HDRS += type_iso.CLIST_ED_Doc.h
HDRS += type_iso.CLIST_ED_Doc_Inline.h
HDRS += type_iso.CLIST_ED_Doc_Ref.h
HDRS += type_iso.CLIST_ED_Image.h
HDRS += type_iso.CLIST_ED_Narrative.h
HDRS += type_iso.CLIST_ED_Signature.h
HDRS += type_iso.CLIST_ED_Text.h
HDRS += type_iso.CLIST_EN.h
HDRS += type_iso.CLIST_EN_ON.h
HDRS += type_iso.CLIST_EN_PN.h
HDRS += type_iso.CLIST_EN_TN.h
HDRS += type_iso.CLIST_II.h
HDRS += type_iso.CLIST_INT.h
HDRS += type_iso.CLIST_INT_NonNeg.h
HDRS += type_iso.CLIST_INT_Positive.h
HDRS += type_iso.CLIST_MO.h
HDRS += type_iso.CLIST_PQ.h
HDRS += type_iso.CLIST_PQ_Time.h
HDRS += type_iso.CLIST_REAL.h
HDRS += type_iso.CLIST_RTO.h
HDRS += type_iso.CLIST_SC.h
HDRS += type_iso.CLIST_SC_NT.h
HDRS += type_iso.CLIST_ST.h
HDRS += type_iso.CLIST_ST_NT.h
HDRS += type_iso.CLIST_TEL.h
HDRS += type_iso.CLIST_TEL_Email.h
HDRS += type_iso.CLIST_TEL_Person.h
HDRS += type_iso.CLIST_TEL_Phone.h
HDRS += type_iso.CLIST_TEL_Url.h
HDRS += type_iso.CLIST_TS.h
HDRS += type_iso.CLIST_TS_Birth.h
HDRS += type_iso.CLIST_TS_Date.h
HDRS += type_iso.CLIST_TS_Date_Full.h
HDRS += type_iso.CLIST_TS_DateTime.h
HDRS += type_iso.CLIST_TS_DateTime_Full.h
HDRS += type_iso.CMO.h
HDRS += type_iso.CNPPD_AD.h
HDRS += type_iso.CNPPD_BL.h
HDRS += type_iso.CNPPD_BL_NonNull.h
HDRS += type_iso.CNPPD_CD.h
HDRS += type_iso.CNPPD_CD_CE.h
HDRS += type_iso.CNPPD_CD_CE_None.h
HDRS += type_iso.CNPPD_CD_CV.h
HDRS += type_iso.CNPPD_CO.h
HDRS += type_iso.CNPPD_CS.h
HDRS += type_iso.CNPPD_ED.h
HDRS += type_iso.CNPPD_ED_Doc.h
HDRS += type_iso.CNPPD_ED_Doc_Inline.h
HDRS += type_iso.CNPPD_ED_Doc_Ref.h
HDRS += type_iso.CNPPD_ED_Image.h
HDRS += type_iso.CNPPD_ED_Narrative.h
HDRS += type_iso.CNPPD_ED_Signature.h
HDRS += type_iso.CNPPD_ED_Text.h
HDRS += type_iso.CNPPD_EN.h
HDRS += type_iso.CNPPD_EN_ON.h
HDRS += type_iso.CNPPD_EN_PN.h
HDRS += type_iso.CNPPD_EN_TN.h
HDRS += type_iso.CNPPD_II.h
HDRS += type_iso.CNPPD_INT.h
HDRS += type_iso.CNPPD_INT_NonNeg.h
HDRS += type_iso.CNPPD_INT_Positive.h
HDRS += type_iso.CNPPD_MO.h
HDRS += type_iso.CNPPD_PQ.h
HDRS += type_iso.CNPPD_PQ_Time.h
HDRS += type_iso.CNPPD_REAL.h
HDRS += type_iso.CNPPD_RTO.h
HDRS += type_iso.CNPPD_SC.h
HDRS += type_iso.CNPPD_SC_NT.h
HDRS += type_iso.CNPPD_ST.h
HDRS += type_iso.CNPPD_ST_NT.h
HDRS += type_iso.CNPPD_TEL.h
HDRS += type_iso.CNPPD_TEL_Email.h
HDRS += type_iso.CNPPD_TEL_Person.h
HDRS += type_iso.CNPPD_TEL_Phone.h
HDRS += type_iso.CNPPD_TEL_Url.h
HDRS += type_iso.CNPPD_TS.h
HDRS += type_iso.CNPPD_TS_Birth.h
HDRS += type_iso.CNPPD_TS_Date.h
HDRS += type_iso.CNPPD_TS_Date_Full.h
HDRS += type_iso.CNPPD_TS_DateTime.h
HDRS += type_iso.CNPPD_TS_DateTime_Full.h
HDRS += type_iso.CNarrative.h
HDRS += type_iso.CNullFlavor.h
HDRS += type_iso.CPIVL_TS.h
HDRS += type_iso.CPIVL_TS_Birth.h
HDRS += type_iso.CPIVL_TS_Date.h
HDRS += type_iso.CPIVL_TS_Date_Full.h
HDRS += type_iso.CPIVL_TS_DateTime.h
HDRS += type_iso.CPIVL_TS_DateTime_Full.h
HDRS += type_iso.CPQ.h
HDRS += type_iso.CPQ_Time.h
HDRS += type_iso.CPQR.h
HDRS += type_iso.CPostalAddressUse.h
HDRS += type_iso.CQSD_CO.h
HDRS += type_iso.CQSD_INT.h
HDRS += type_iso.CQSD_INT_NonNeg.h
HDRS += type_iso.CQSD_INT_Positive.h
HDRS += type_iso.CQSD_MO.h
HDRS += type_iso.CQSD_PQ.h
HDRS += type_iso.CQSD_PQ_Time.h
HDRS += type_iso.CQSD_REAL.h
HDRS += type_iso.CQSD_RTO.h
HDRS += type_iso.CQSD_TS.h
HDRS += type_iso.CQSD_TS_Birth.h
HDRS += type_iso.CQSD_TS_Date.h
HDRS += type_iso.CQSD_TS_Date_Full.h
HDRS += type_iso.CQSD_TS_DateTime.h
HDRS += type_iso.CQSD_TS_DateTime_Full.h
HDRS += type_iso.CQSET_BoundedPIVL.h
HDRS += type_iso.CQSET_CO.h
HDRS += type_iso.CQSET_INT.h
HDRS += type_iso.CQSET_INT_NonNeg.h
HDRS += type_iso.CQSET_INT_Positive.h
HDRS += type_iso.CQSET_MO.h
HDRS += type_iso.CQSET_PQ.h
HDRS += type_iso.CQSET_PQ_Time.h
HDRS += type_iso.CQSET_REAL.h
HDRS += type_iso.CQSET_RTO.h
HDRS += type_iso.CQSET_TS.h
HDRS += type_iso.CQSET_TS_Birth.h
HDRS += type_iso.CQSET_TS_Date.h
HDRS += type_iso.CQSET_TS_Date_Full.h
HDRS += type_iso.CQSET_TS_DateTime.h
HDRS += type_iso.CQSET_TS_DateTime_Full.h
HDRS += type_iso.CQSI_CO.h
HDRS += type_iso.CQSI_INT.h
HDRS += type_iso.CQSI_INT_NonNeg.h
HDRS += type_iso.CQSI_INT_Positive.h
HDRS += type_iso.CQSI_MO.h
HDRS += type_iso.CQSI_PQ.h
HDRS += type_iso.CQSI_PQ_Time.h
HDRS += type_iso.CQSI_REAL.h
HDRS += type_iso.CQSI_RTO.h
HDRS += type_iso.CQSI_TS.h
HDRS += type_iso.CQSI_TS_Birth.h
HDRS += type_iso.CQSI_TS_Date.h
HDRS += type_iso.CQSI_TS_Date_Full.h
HDRS += type_iso.CQSI_TS_DateTime.h
HDRS += type_iso.CQSI_TS_DateTime_Full.h
HDRS += type_iso.CQSP_CO.h
HDRS += type_iso.CQSP_INT.h
HDRS += type_iso.CQSP_INT_NonNeg.h
HDRS += type_iso.CQSP_INT_Positive.h
HDRS += type_iso.CQSP_MO.h
HDRS += type_iso.CQSP_PQ.h
HDRS += type_iso.CQSP_PQ_Time.h
HDRS += type_iso.CQSP_REAL.h
HDRS += type_iso.CQSP_RTO.h
HDRS += type_iso.CQSP_TS.h
HDRS += type_iso.CQSP_TS_Birth.h
HDRS += type_iso.CQSP_TS_Date.h
HDRS += type_iso.CQSP_TS_Date_Full.h
HDRS += type_iso.CQSP_TS_DateTime.h
HDRS += type_iso.CQSP_TS_DateTime_Full.h
HDRS += type_iso.CQSS_CO.h
HDRS += type_iso.CQSS_INT.h
HDRS += type_iso.CQSS_INT_NonNeg.h
HDRS += type_iso.CQSS_INT_Positive.h
HDRS += type_iso.CQSS_MO.h
HDRS += type_iso.CQSS_PQ.h
HDRS += type_iso.CQSS_PQ_Time.h
HDRS += type_iso.CQSS_REAL.h
HDRS += type_iso.CQSS_RTO.h
HDRS += type_iso.CQSS_TS.h
HDRS += type_iso.CQSS_TS_Birth.h
HDRS += type_iso.CQSS_TS_Date.h
HDRS += type_iso.CQSS_TS_Date_Full.h
HDRS += type_iso.CQSS_TS_DateTime.h
HDRS += type_iso.CQSS_TS_DateTime_Full.h
HDRS += type_iso.CQSU_CO.h
HDRS += type_iso.CQSU_INT.h
HDRS += type_iso.CQSU_INT_NonNeg.h
HDRS += type_iso.CQSU_INT_Positive.h
HDRS += type_iso.CQSU_MO.h
HDRS += type_iso.CQSU_PQ.h
HDRS += type_iso.CQSU_PQ_Time.h
HDRS += type_iso.CQSU_REAL.h
HDRS += type_iso.CQSU_RTO.h
HDRS += type_iso.CQSU_TS.h
HDRS += type_iso.CQSU_TS_Birth.h
HDRS += type_iso.CQSU_TS_Date.h
HDRS += type_iso.CQSU_TS_Date_Full.h
HDRS += type_iso.CQSU_TS_DateTime.h
HDRS += type_iso.CQSU_TS_DateTime_Full.h
HDRS += type_iso.CQTY.h
HDRS += type_iso.CREAL.h
HDRS += type_iso.CRTO.h
HDRS += type_iso.CSC.h
HDRS += type_iso.CSC_NT.h
HDRS += type_iso.CSLIST_CO.h
HDRS += type_iso.CSLIST_INT.h
HDRS += type_iso.CSLIST_INT_NonNeg.h
HDRS += type_iso.CSLIST_INT_Positive.h
HDRS += type_iso.CSLIST_MO.h
HDRS += type_iso.CSLIST_PQ.h
HDRS += type_iso.CSLIST_PQ_Time.h
HDRS += type_iso.CSLIST_REAL.h
HDRS += type_iso.CSLIST_RTO.h
HDRS += type_iso.CSLIST_TS.h
HDRS += type_iso.CSLIST_TS_Birth.h
HDRS += type_iso.CSLIST_TS_Date.h
HDRS += type_iso.CSLIST_TS_Date_Full.h
HDRS += type_iso.CSLIST_TS_DateTime.h
HDRS += type_iso.CSLIST_TS_DateTime_Full.h
HDRS += type_iso.CST.h
HDRS += type_iso.CST_NT.h
HDRS += type_iso.CTEL.h
HDRS += type_iso.CTEL_Email.h
HDRS += type_iso.CTEL_Person.h
HDRS += type_iso.CTEL_Phone.h
HDRS += type_iso.CTEL_Url.h
HDRS += type_iso.CTS.h
HDRS += type_iso.CTS_Birth.h
HDRS += type_iso.CTS_Date.h
HDRS += type_iso.CTS_Date_Full.h
HDRS += type_iso.CTS_DateTime.h
HDRS += type_iso.CTS_DateTime_Full.h
HDRS += type_iso.CTelecommunicationAddressUse.h
HDRS += type_iso.CTimingEvent.h
HDRS += type_iso.CURL.h
HDRS += type_iso.CUVP_AD.h
HDRS += type_iso.CUVP_BL.h
HDRS += type_iso.CUVP_BL_NonNull.h
HDRS += type_iso.CUVP_CD.h
HDRS += type_iso.CUVP_CD_CE.h
HDRS += type_iso.CUVP_CD_CE_None.h
HDRS += type_iso.CUVP_CD_CV.h
HDRS += type_iso.CUVP_CO.h
HDRS += type_iso.CUVP_CS.h
HDRS += type_iso.CUVP_ED.h
HDRS += type_iso.CUVP_ED_Doc.h
HDRS += type_iso.CUVP_ED_Doc_Inline.h
HDRS += type_iso.CUVP_ED_Doc_Ref.h
HDRS += type_iso.CUVP_ED_Image.h
HDRS += type_iso.CUVP_ED_Narrative.h
HDRS += type_iso.CUVP_ED_Signature.h
HDRS += type_iso.CUVP_ED_Text.h
HDRS += type_iso.CUVP_EN.h
HDRS += type_iso.CUVP_EN_ON.h
HDRS += type_iso.CUVP_EN_PN.h
HDRS += type_iso.CUVP_EN_TN.h
HDRS += type_iso.CUVP_II.h
HDRS += type_iso.CUVP_INT.h
HDRS += type_iso.CUVP_INT_NonNeg.h
HDRS += type_iso.CUVP_INT_Positive.h
HDRS += type_iso.CUVP_MO.h
HDRS += type_iso.CUVP_PQ.h
HDRS += type_iso.CUVP_PQ_Time.h
HDRS += type_iso.CUVP_REAL.h
HDRS += type_iso.CUVP_RTO.h
HDRS += type_iso.CUVP_SC.h
HDRS += type_iso.CUVP_SC_NT.h
HDRS += type_iso.CUVP_ST.h
HDRS += type_iso.CUVP_ST_NT.h
HDRS += type_iso.CUVP_TEL.h
HDRS += type_iso.CUVP_TEL_Email.h
HDRS += type_iso.CUVP_TEL_Person.h
HDRS += type_iso.CUVP_TEL_Phone.h
HDRS += type_iso.CUVP_TEL_Url.h
HDRS += type_iso.CUVP_TS.h
HDRS += type_iso.CUVP_TS_Birth.h
HDRS += type_iso.CUVP_TS_Date.h
HDRS += type_iso.CUVP_TS_Date_Full.h
HDRS += type_iso.CUVP_TS_DateTime.h
HDRS += type_iso.CUVP_TS_DateTime_Full.h
HDRS += type_iso.CUid.h
HDRS += type_iso.CUncertaintyType.h
HDRS += type_iso.CUpdateMode.h
HDRS += type_iso.CUri.h
HDRS += type_iso.CXReference.h
HDRS += type_iso.Cset_CodingRationale.h
HDRS += type_iso.Cset_EntityNamePartQualifier.h
HDRS += type_iso.Cset_EntityNameUse.h
HDRS += type_iso.Cset_PostalAddressUse.h
HDRS += type_iso.Cset_TelecommunicationAddressUse.h


SRCS = AIMXML.cpp AIMXML-typeinfo.cpp

OBJS = $(filter %.o, $(SRCS:.cpp=.o))
Q ?= @

# Xerces-C non-shared installation support
ifneq ($(strip $(LIB_XERCESC_FOLDER)),)
DEPLIBS += $(strip $(LIB_XERCESC_FOLDER))/libxerces-c.a
SHAREDDEPLIBS += $(strip $(LIB_XERCESC_FOLDER))/libxerces-c.so
endif

.PHONY: all clean


all: $(LIB)


$(SHAREDLIB): $(OBJS) $(SHAREDDEPLIBS)
	@echo '===> Linking shared $(SHAREDLIB)'
	$(Q)gcc -shared -Wl,-soname,$(SHAREDLIB) -o $(SHAREDLIB)$(VERSION) $(OBJS)
	$(Q)ln -s $(SHAREDLIB)$(VERSION) $(SHAREDLIB)

$(LIB): $(OBJS) $(DEPLIBS)
	@echo '===> Linking $(LIB)'
	$(Q)ar cr $(LIB) $(OBJS)
	$(Q)ranlib $(LIB)

$(OBJS): $(HDRS) $(SRCS)

clean:
	rm -Rf $(OBJS) $(LIB) $(SHAREDLIB)
