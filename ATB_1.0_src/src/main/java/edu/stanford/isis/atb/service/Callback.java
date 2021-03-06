/*
*  2010 � 2012 Copyright Northwestern University and Stanford University 
*
*  Distributed under the OSI-approved BSD 3-Clause License.
*  See http://ncip.github.com/annotation-and-image-markup/LICENSE.txt for details.
*/



package edu.stanford.isis.atb.service;


/**
 * @author Vitaliy Semeshko
 */
public interface Callback<T> {

	public void onSuccess(T result);
	
	public void onFailure(Throwable caught);
	
}
