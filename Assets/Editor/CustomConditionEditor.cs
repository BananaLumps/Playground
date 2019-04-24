using GameFlow;
using UnityEditor;

namespace Custom {

[CustomEditor(typeof(CustomCondition), true)]
public class CustomConditionEditor : ConditionEditor {

	// Declare properties exactly as defined in the Condition subclass
	protected SerializedProperty _number;
	protected SerializedProperty _numberVar;
	protected SerializedProperty _comparison;

	// Condition user interface
	public override void OnConditionGUI() {
		// Draws a Variable-friendly numeric field in the Inspector
		PropertyField("Number", _number, _numberVar);
		// Draws a label that you can click for additional options
		PopupLabel(_comparison, true);
	}

}

}
