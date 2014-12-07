#region Copyright
////////////////////////////////////////////////////////////////////////////////
// The following FIT Protocol software provided may be used with FIT protocol
// devices only and remains the copyrighted property of Dynastream Innovations Inc.
// The software is being provided on an "as-is" basis and as an accommodation,
// and therefore all warranties, representations, or guarantees of any kind
// (whether express, implied or statutory) including, without limitation,
// warranties of merchantability, non-infringement, or fitness for a particular
// purpose, are specifically disclaimed.
//
// Copyright 2014 Dynastream Innovations Inc.
////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 12.20Release
// Tag = $Name$
////////////////////////////////////////////////////////////////////////////////

#endregion

namespace FitFilePreviewer.Decode.Fit.Mesgs
{
   /// <summary>
   /// Implements the WorkoutStep profile message.
   /// </summary>  
   public class WorkoutStepMesg : Mesg 
   {    
      #region Fields            
      static class DurationValueSubfield
      {
         public static ushort DurationTime = 0;
         public static ushort DurationDistance = 1;
         public static ushort DurationHr = 2;
         public static ushort DurationCalories = 3;
         public static ushort DurationStep = 4;
         public static ushort DurationPower = 5;
         public static ushort Subfields = 6;
         public static ushort Active = Fit.SubfieldIndexActiveSubfield;
         public static ushort MainField = Fit.SubfieldIndexMainField;
      }            
      static class TargetValueSubfield
      {
         public static ushort TargetHrZone = 0;
         public static ushort TargetPowerZone = 1;
         public static ushort RepeatSteps = 2;
         public static ushort RepeatTime = 3;
         public static ushort RepeatDistance = 4;
         public static ushort RepeatCalories = 5;
         public static ushort RepeatHr = 6;
         public static ushort RepeatPower = 7;
         public static ushort Subfields = 8;
         public static ushort Active = Fit.SubfieldIndexActiveSubfield;
         public static ushort MainField = Fit.SubfieldIndexMainField;
      }            
      static class CustomTargetValueLowSubfield
      {
         public static ushort CustomTargetSpeedLow = 0;
         public static ushort CustomTargetHeartRateLow = 1;
         public static ushort CustomTargetCadenceLow = 2;
         public static ushort CustomTargetPowerLow = 3;
         public static ushort Subfields = 4;
         public static ushort Active = Fit.SubfieldIndexActiveSubfield;
         public static ushort MainField = Fit.SubfieldIndexMainField;
      }            
      static class CustomTargetValueHighSubfield
      {
         public static ushort CustomTargetSpeedHigh = 0;
         public static ushort CustomTargetHeartRateHigh = 1;
         public static ushort CustomTargetCadenceHigh = 2;
         public static ushort CustomTargetPowerHigh = 3;
         public static ushort Subfields = 4;
         public static ushort Active = Fit.SubfieldIndexActiveSubfield;
         public static ushort MainField = Fit.SubfieldIndexMainField;
      }     
      #endregion

      #region Constructors                 
      public WorkoutStepMesg() : base((Mesg) Profile.mesgs[Profile.WorkoutStepIndex])               
      {                 
      }
      
      public WorkoutStepMesg(Mesg mesg) : base(mesg)
      {
      }
      #endregion // Constructors

      #region Methods    
      ///<summary>      
      /// Retrieves the MessageIndex field</summary>
      /// <returns>Returns nullable ushort representing the MessageIndex field</returns>      
      public ushort? GetMessageIndex()   
      {                
         return (ushort?)GetFieldValue(254, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set MessageIndex field</summary>
      /// <param name="messageIndex_">Nullable field value to be set</param>      
      public void SetMessageIndex(ushort? messageIndex_) 
      {  
         SetFieldValue(254, 0, messageIndex_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the WktStepName field</summary>
      /// <returns>Returns byte[] representing the WktStepName field</returns>      
      public byte[] GetWktStepName()   
      {                
         return (byte[])GetFieldValue(0, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set WktStepName field</summary>
      /// <param name="wktStepName_">field value to be set</param>      
      public void SetWktStepName(byte[] wktStepName_) 
      {  
         SetFieldValue(0, 0, wktStepName_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the DurationType field</summary>
      /// <returns>Returns nullable WktStepDuration enum representing the DurationType field</returns>      
      public Types.WktStepDuration? GetDurationType()   
      { 
         object obj = GetFieldValue(1, 0, Fit.SubfieldIndexMainField);
         Types.WktStepDuration? value = obj == null ? (Types.WktStepDuration?)null : (Types.WktStepDuration)obj;
         return value;                     
      }

      /// <summary>        
      /// Set DurationType field</summary>
      /// <param name="durationType_">Nullable field value to be set</param>      
      public void SetDurationType(Types.WktStepDuration? durationType_) 
      {  
         SetFieldValue(1, 0, durationType_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the DurationValue field</summary>
      /// <returns>Returns nullable uint representing the DurationValue field</returns>      
      public uint? GetDurationValue()   
      {                
         return (uint?)GetFieldValue(2, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set DurationValue field</summary>
      /// <param name="durationValue_">Nullable field value to be set</param>      
      public void SetDurationValue(uint? durationValue_) 
      {  
         SetFieldValue(2, 0, durationValue_, Fit.SubfieldIndexMainField);
      }
      

      /// <summary>       
      /// Retrieves the DurationTime subfield
      /// Units: s</summary>      
      /// <returns>Nullable float representing the DurationTime subfield</returns>      
      public float? GetDurationTime() 
      {                               
         return (float?)GetFieldValue(2, 0, DurationValueSubfield.DurationTime);   
      }

      /// <summary> 
      /// 
      /// Set DurationTime subfield
      /// Units: s</summary>
      /// <param name="durationTime">Subfield value to be set</param>      
      public void SetDurationTime(float? durationTime) 
      {  
         SetFieldValue(2, 0, durationTime, DurationValueSubfield.DurationTime);
      }

      /// <summary>       
      /// Retrieves the DurationDistance subfield
      /// Units: m</summary>      
      /// <returns>Nullable float representing the DurationDistance subfield</returns>      
      public float? GetDurationDistance() 
      {                               
         return (float?)GetFieldValue(2, 0, DurationValueSubfield.DurationDistance);   
      }

      /// <summary> 
      /// 
      /// Set DurationDistance subfield
      /// Units: m</summary>
      /// <param name="durationDistance">Subfield value to be set</param>      
      public void SetDurationDistance(float? durationDistance) 
      {  
         SetFieldValue(2, 0, durationDistance, DurationValueSubfield.DurationDistance);
      }

      /// <summary>       
      /// Retrieves the DurationHr subfield
      /// Units: % or bpm</summary>      
      /// <returns>Nullable uint representing the DurationHr subfield</returns>      
      public uint? GetDurationHr() 
      {                               
         return (uint?)GetFieldValue(2, 0, DurationValueSubfield.DurationHr);   
      }

      /// <summary> 
      /// 
      /// Set DurationHr subfield
      /// Units: % or bpm</summary>
      /// <param name="durationHr">Subfield value to be set</param>      
      public void SetDurationHr(uint? durationHr) 
      {  
         SetFieldValue(2, 0, durationHr, DurationValueSubfield.DurationHr);
      }

      /// <summary>       
      /// Retrieves the DurationCalories subfield
      /// Units: calories</summary>      
      /// <returns>Nullable uint representing the DurationCalories subfield</returns>      
      public uint? GetDurationCalories() 
      {                               
         return (uint?)GetFieldValue(2, 0, DurationValueSubfield.DurationCalories);   
      }

      /// <summary> 
      /// 
      /// Set DurationCalories subfield
      /// Units: calories</summary>
      /// <param name="durationCalories">Subfield value to be set</param>      
      public void SetDurationCalories(uint? durationCalories) 
      {  
         SetFieldValue(2, 0, durationCalories, DurationValueSubfield.DurationCalories);
      }

      /// <summary>       
      /// Retrieves the DurationStep subfield
      /// Comment: message_index of step to loop back to. Steps are assumed to be in the order by message_index. custom_name and intensity members are undefined for this duration type.</summary>      
      /// <returns>Nullable uint representing the DurationStep subfield</returns>      
      public uint? GetDurationStep() 
      {                               
         return (uint?)GetFieldValue(2, 0, DurationValueSubfield.DurationStep);   
      }

      /// <summary> 
      /// 
      /// Set DurationStep subfield
      /// Comment: message_index of step to loop back to. Steps are assumed to be in the order by message_index. custom_name and intensity members are undefined for this duration type.</summary>
      /// <param name="durationStep">Subfield value to be set</param>      
      public void SetDurationStep(uint? durationStep) 
      {  
         SetFieldValue(2, 0, durationStep, DurationValueSubfield.DurationStep);
      }

      /// <summary>       
      /// Retrieves the DurationPower subfield
      /// Units: % or watts</summary>      
      /// <returns>Nullable uint representing the DurationPower subfield</returns>      
      public uint? GetDurationPower() 
      {                               
         return (uint?)GetFieldValue(2, 0, DurationValueSubfield.DurationPower);   
      }

      /// <summary> 
      /// 
      /// Set DurationPower subfield
      /// Units: % or watts</summary>
      /// <param name="durationPower">Subfield value to be set</param>      
      public void SetDurationPower(uint? durationPower) 
      {  
         SetFieldValue(2, 0, durationPower, DurationValueSubfield.DurationPower);
      }    
      ///<summary>      
      /// Retrieves the TargetType field</summary>
      /// <returns>Returns nullable WktStepTarget enum representing the TargetType field</returns>      
      public Types.WktStepTarget? GetTargetType()   
      { 
         object obj = GetFieldValue(3, 0, Fit.SubfieldIndexMainField);
         Types.WktStepTarget? value = obj == null ? (Types.WktStepTarget?)null : (Types.WktStepTarget)obj;
         return value;                     
      }

      /// <summary>        
      /// Set TargetType field</summary>
      /// <param name="targetType_">Nullable field value to be set</param>      
      public void SetTargetType(Types.WktStepTarget? targetType_) 
      {  
         SetFieldValue(3, 0, targetType_, Fit.SubfieldIndexMainField);
      }
          
      ///<summary>      
      /// Retrieves the TargetValue field</summary>
      /// <returns>Returns nullable uint representing the TargetValue field</returns>      
      public uint? GetTargetValue()   
      {                
         return (uint?)GetFieldValue(4, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set TargetValue field</summary>
      /// <param name="targetValue_">Nullable field value to be set</param>      
      public void SetTargetValue(uint? targetValue_) 
      {  
         SetFieldValue(4, 0, targetValue_, Fit.SubfieldIndexMainField);
      }
      

      /// <summary>       
      /// Retrieves the TargetHrZone subfield
      /// Comment: hr zone (1-5);Custom =0;</summary>      
      /// <returns>Nullable uint representing the TargetHrZone subfield</returns>      
      public uint? GetTargetHrZone() 
      {                               
         return (uint?)GetFieldValue(4, 0, TargetValueSubfield.TargetHrZone);   
      }

      /// <summary> 
      /// 
      /// Set TargetHrZone subfield
      /// Comment: hr zone (1-5);Custom =0;</summary>
      /// <param name="targetHrZone">Subfield value to be set</param>      
      public void SetTargetHrZone(uint? targetHrZone) 
      {  
         SetFieldValue(4, 0, targetHrZone, TargetValueSubfield.TargetHrZone);
      }

      /// <summary>       
      /// Retrieves the TargetPowerZone subfield
      /// Comment: Power Zone ( 1-7); Custom = 0;</summary>      
      /// <returns>Nullable uint representing the TargetPowerZone subfield</returns>      
      public uint? GetTargetPowerZone() 
      {                               
         return (uint?)GetFieldValue(4, 0, TargetValueSubfield.TargetPowerZone);   
      }

      /// <summary> 
      /// 
      /// Set TargetPowerZone subfield
      /// Comment: Power Zone ( 1-7); Custom = 0;</summary>
      /// <param name="targetPowerZone">Subfield value to be set</param>      
      public void SetTargetPowerZone(uint? targetPowerZone) 
      {  
         SetFieldValue(4, 0, targetPowerZone, TargetValueSubfield.TargetPowerZone);
      }

      /// <summary>       
      /// Retrieves the RepeatSteps subfield
      /// Comment: # of repetitions</summary>      
      /// <returns>Nullable uint representing the RepeatSteps subfield</returns>      
      public uint? GetRepeatSteps() 
      {                               
         return (uint?)GetFieldValue(4, 0, TargetValueSubfield.RepeatSteps);   
      }

      /// <summary> 
      /// 
      /// Set RepeatSteps subfield
      /// Comment: # of repetitions</summary>
      /// <param name="repeatSteps">Subfield value to be set</param>      
      public void SetRepeatSteps(uint? repeatSteps) 
      {  
         SetFieldValue(4, 0, repeatSteps, TargetValueSubfield.RepeatSteps);
      }

      /// <summary>       
      /// Retrieves the RepeatTime subfield
      /// Units: s</summary>      
      /// <returns>Nullable float representing the RepeatTime subfield</returns>      
      public float? GetRepeatTime() 
      {                               
         return (float?)GetFieldValue(4, 0, TargetValueSubfield.RepeatTime);   
      }

      /// <summary> 
      /// 
      /// Set RepeatTime subfield
      /// Units: s</summary>
      /// <param name="repeatTime">Subfield value to be set</param>      
      public void SetRepeatTime(float? repeatTime) 
      {  
         SetFieldValue(4, 0, repeatTime, TargetValueSubfield.RepeatTime);
      }

      /// <summary>       
      /// Retrieves the RepeatDistance subfield
      /// Units: m</summary>      
      /// <returns>Nullable float representing the RepeatDistance subfield</returns>      
      public float? GetRepeatDistance() 
      {                               
         return (float?)GetFieldValue(4, 0, TargetValueSubfield.RepeatDistance);   
      }

      /// <summary> 
      /// 
      /// Set RepeatDistance subfield
      /// Units: m</summary>
      /// <param name="repeatDistance">Subfield value to be set</param>      
      public void SetRepeatDistance(float? repeatDistance) 
      {  
         SetFieldValue(4, 0, repeatDistance, TargetValueSubfield.RepeatDistance);
      }

      /// <summary>       
      /// Retrieves the RepeatCalories subfield
      /// Units: calories</summary>      
      /// <returns>Nullable uint representing the RepeatCalories subfield</returns>      
      public uint? GetRepeatCalories() 
      {                               
         return (uint?)GetFieldValue(4, 0, TargetValueSubfield.RepeatCalories);   
      }

      /// <summary> 
      /// 
      /// Set RepeatCalories subfield
      /// Units: calories</summary>
      /// <param name="repeatCalories">Subfield value to be set</param>      
      public void SetRepeatCalories(uint? repeatCalories) 
      {  
         SetFieldValue(4, 0, repeatCalories, TargetValueSubfield.RepeatCalories);
      }

      /// <summary>       
      /// Retrieves the RepeatHr subfield
      /// Units: % or bpm</summary>      
      /// <returns>Nullable uint representing the RepeatHr subfield</returns>      
      public uint? GetRepeatHr() 
      {                               
         return (uint?)GetFieldValue(4, 0, TargetValueSubfield.RepeatHr);   
      }

      /// <summary> 
      /// 
      /// Set RepeatHr subfield
      /// Units: % or bpm</summary>
      /// <param name="repeatHr">Subfield value to be set</param>      
      public void SetRepeatHr(uint? repeatHr) 
      {  
         SetFieldValue(4, 0, repeatHr, TargetValueSubfield.RepeatHr);
      }

      /// <summary>       
      /// Retrieves the RepeatPower subfield
      /// Units: % or watts</summary>      
      /// <returns>Nullable uint representing the RepeatPower subfield</returns>      
      public uint? GetRepeatPower() 
      {                               
         return (uint?)GetFieldValue(4, 0, TargetValueSubfield.RepeatPower);   
      }

      /// <summary> 
      /// 
      /// Set RepeatPower subfield
      /// Units: % or watts</summary>
      /// <param name="repeatPower">Subfield value to be set</param>      
      public void SetRepeatPower(uint? repeatPower) 
      {  
         SetFieldValue(4, 0, repeatPower, TargetValueSubfield.RepeatPower);
      }    
      ///<summary>      
      /// Retrieves the CustomTargetValueLow field</summary>
      /// <returns>Returns nullable uint representing the CustomTargetValueLow field</returns>      
      public uint? GetCustomTargetValueLow()   
      {                
         return (uint?)GetFieldValue(5, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set CustomTargetValueLow field</summary>
      /// <param name="customTargetValueLow_">Nullable field value to be set</param>      
      public void SetCustomTargetValueLow(uint? customTargetValueLow_) 
      {  
         SetFieldValue(5, 0, customTargetValueLow_, Fit.SubfieldIndexMainField);
      }
      

      /// <summary>       
      /// Retrieves the CustomTargetSpeedLow subfield
      /// Units: m/s</summary>      
      /// <returns>Nullable float representing the CustomTargetSpeedLow subfield</returns>      
      public float? GetCustomTargetSpeedLow() 
      {                               
         return (float?)GetFieldValue(5, 0, CustomTargetValueLowSubfield.CustomTargetSpeedLow);   
      }

      /// <summary> 
      /// 
      /// Set CustomTargetSpeedLow subfield
      /// Units: m/s</summary>
      /// <param name="customTargetSpeedLow">Subfield value to be set</param>      
      public void SetCustomTargetSpeedLow(float? customTargetSpeedLow) 
      {  
         SetFieldValue(5, 0, customTargetSpeedLow, CustomTargetValueLowSubfield.CustomTargetSpeedLow);
      }

      /// <summary>       
      /// Retrieves the CustomTargetHeartRateLow subfield
      /// Units: % or bpm</summary>      
      /// <returns>Nullable uint representing the CustomTargetHeartRateLow subfield</returns>      
      public uint? GetCustomTargetHeartRateLow() 
      {                               
         return (uint?)GetFieldValue(5, 0, CustomTargetValueLowSubfield.CustomTargetHeartRateLow);   
      }

      /// <summary> 
      /// 
      /// Set CustomTargetHeartRateLow subfield
      /// Units: % or bpm</summary>
      /// <param name="customTargetHeartRateLow">Subfield value to be set</param>      
      public void SetCustomTargetHeartRateLow(uint? customTargetHeartRateLow) 
      {  
         SetFieldValue(5, 0, customTargetHeartRateLow, CustomTargetValueLowSubfield.CustomTargetHeartRateLow);
      }

      /// <summary>       
      /// Retrieves the CustomTargetCadenceLow subfield
      /// Units: rpm</summary>      
      /// <returns>Nullable uint representing the CustomTargetCadenceLow subfield</returns>      
      public uint? GetCustomTargetCadenceLow() 
      {                               
         return (uint?)GetFieldValue(5, 0, CustomTargetValueLowSubfield.CustomTargetCadenceLow);   
      }

      /// <summary> 
      /// 
      /// Set CustomTargetCadenceLow subfield
      /// Units: rpm</summary>
      /// <param name="customTargetCadenceLow">Subfield value to be set</param>      
      public void SetCustomTargetCadenceLow(uint? customTargetCadenceLow) 
      {  
         SetFieldValue(5, 0, customTargetCadenceLow, CustomTargetValueLowSubfield.CustomTargetCadenceLow);
      }

      /// <summary>       
      /// Retrieves the CustomTargetPowerLow subfield
      /// Units: % or watts</summary>      
      /// <returns>Nullable uint representing the CustomTargetPowerLow subfield</returns>      
      public uint? GetCustomTargetPowerLow() 
      {                               
         return (uint?)GetFieldValue(5, 0, CustomTargetValueLowSubfield.CustomTargetPowerLow);   
      }

      /// <summary> 
      /// 
      /// Set CustomTargetPowerLow subfield
      /// Units: % or watts</summary>
      /// <param name="customTargetPowerLow">Subfield value to be set</param>      
      public void SetCustomTargetPowerLow(uint? customTargetPowerLow) 
      {  
         SetFieldValue(5, 0, customTargetPowerLow, CustomTargetValueLowSubfield.CustomTargetPowerLow);
      }    
      ///<summary>      
      /// Retrieves the CustomTargetValueHigh field</summary>
      /// <returns>Returns nullable uint representing the CustomTargetValueHigh field</returns>      
      public uint? GetCustomTargetValueHigh()   
      {                
         return (uint?)GetFieldValue(6, 0, Fit.SubfieldIndexMainField);                     
      }

      /// <summary>        
      /// Set CustomTargetValueHigh field</summary>
      /// <param name="customTargetValueHigh_">Nullable field value to be set</param>      
      public void SetCustomTargetValueHigh(uint? customTargetValueHigh_) 
      {  
         SetFieldValue(6, 0, customTargetValueHigh_, Fit.SubfieldIndexMainField);
      }
      

      /// <summary>       
      /// Retrieves the CustomTargetSpeedHigh subfield
      /// Units: m/s</summary>      
      /// <returns>Nullable float representing the CustomTargetSpeedHigh subfield</returns>      
      public float? GetCustomTargetSpeedHigh() 
      {                               
         return (float?)GetFieldValue(6, 0, CustomTargetValueHighSubfield.CustomTargetSpeedHigh);   
      }

      /// <summary> 
      /// 
      /// Set CustomTargetSpeedHigh subfield
      /// Units: m/s</summary>
      /// <param name="customTargetSpeedHigh">Subfield value to be set</param>      
      public void SetCustomTargetSpeedHigh(float? customTargetSpeedHigh) 
      {  
         SetFieldValue(6, 0, customTargetSpeedHigh, CustomTargetValueHighSubfield.CustomTargetSpeedHigh);
      }

      /// <summary>       
      /// Retrieves the CustomTargetHeartRateHigh subfield
      /// Units: % or bpm</summary>      
      /// <returns>Nullable uint representing the CustomTargetHeartRateHigh subfield</returns>      
      public uint? GetCustomTargetHeartRateHigh() 
      {                               
         return (uint?)GetFieldValue(6, 0, CustomTargetValueHighSubfield.CustomTargetHeartRateHigh);   
      }

      /// <summary> 
      /// 
      /// Set CustomTargetHeartRateHigh subfield
      /// Units: % or bpm</summary>
      /// <param name="customTargetHeartRateHigh">Subfield value to be set</param>      
      public void SetCustomTargetHeartRateHigh(uint? customTargetHeartRateHigh) 
      {  
         SetFieldValue(6, 0, customTargetHeartRateHigh, CustomTargetValueHighSubfield.CustomTargetHeartRateHigh);
      }

      /// <summary>       
      /// Retrieves the CustomTargetCadenceHigh subfield
      /// Units: rpm</summary>      
      /// <returns>Nullable uint representing the CustomTargetCadenceHigh subfield</returns>      
      public uint? GetCustomTargetCadenceHigh() 
      {                               
         return (uint?)GetFieldValue(6, 0, CustomTargetValueHighSubfield.CustomTargetCadenceHigh);   
      }

      /// <summary> 
      /// 
      /// Set CustomTargetCadenceHigh subfield
      /// Units: rpm</summary>
      /// <param name="customTargetCadenceHigh">Subfield value to be set</param>      
      public void SetCustomTargetCadenceHigh(uint? customTargetCadenceHigh) 
      {  
         SetFieldValue(6, 0, customTargetCadenceHigh, CustomTargetValueHighSubfield.CustomTargetCadenceHigh);
      }

      /// <summary>       
      /// Retrieves the CustomTargetPowerHigh subfield
      /// Units: % or watts</summary>      
      /// <returns>Nullable uint representing the CustomTargetPowerHigh subfield</returns>      
      public uint? GetCustomTargetPowerHigh() 
      {                               
         return (uint?)GetFieldValue(6, 0, CustomTargetValueHighSubfield.CustomTargetPowerHigh);   
      }

      /// <summary> 
      /// 
      /// Set CustomTargetPowerHigh subfield
      /// Units: % or watts</summary>
      /// <param name="customTargetPowerHigh">Subfield value to be set</param>      
      public void SetCustomTargetPowerHigh(uint? customTargetPowerHigh) 
      {  
         SetFieldValue(6, 0, customTargetPowerHigh, CustomTargetValueHighSubfield.CustomTargetPowerHigh);
      }    
      ///<summary>      
      /// Retrieves the Intensity field</summary>
      /// <returns>Returns nullable Intensity enum representing the Intensity field</returns>      
      public Types.Intensity? GetIntensity()   
      { 
         object obj = GetFieldValue(7, 0, Fit.SubfieldIndexMainField);
         Types.Intensity? value = obj == null ? (Types.Intensity?)null : (Types.Intensity)obj;
         return value;                     
      }

      /// <summary>        
      /// Set Intensity field</summary>
      /// <param name="intensity_">Nullable field value to be set</param>      
      public void SetIntensity(Types.Intensity? intensity_) 
      {  
         SetFieldValue(7, 0, intensity_, Fit.SubfieldIndexMainField);
      }
                        
      #endregion // Methods
   } // Class
} // namespace