using UnityEngine;
using UnityEditor;

namespace LudoUtilities
{
    [CustomEditor(typeof(RigidVelocityHelper))]
    [CanEditMultipleObjects]
    public class RigidVelocityHelperEditor : Editor
    {
        SerializedProperty velocity;
        SerializedProperty startWithVelocity;
        SerializedProperty persistentVelocity;
        SerializedProperty enablePersistent;
        SerializedProperty angularVelocity;
        SerializedProperty startWithAngular;

        private void OnEnable()
        {
            velocity = serializedObject.FindProperty("velocity");
            persistentVelocity = serializedObject.FindProperty("persistentVelocity");
            startWithVelocity = serializedObject.FindProperty("startWithVelocity");
            enablePersistent = serializedObject.FindProperty("enablePersistent");
            angularVelocity = serializedObject.FindProperty("angularVelocity");
            startWithAngular = serializedObject.FindProperty("startWithAngular");
        }

        public override void OnInspectorGUI()
        {
            RigidVelocityHelper rv = target as RigidVelocityHelper;
            serializedObject.Update();

            {
                EditorGUILayout.PropertyField(velocity, new GUIContent("Velocity"));
                EditorGUILayout.PropertyField(startWithVelocity, new GUIContent("Start With Velocity"));
                if (GUILayout.Button("Apply Velocity"))
                {
                    rv.ApplyVelocity();
                }
            }
            EditorGUILayout.Space(2);
            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
            EditorGUILayout.Space(2);
            {
                EditorGUILayout.PropertyField(persistentVelocity, new GUIContent("Persistent Velocity"));
                EditorGUILayout.PropertyField(enablePersistent, new GUIContent("Enable Persistent"));
            }
            EditorGUILayout.Space(2);
            EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);
            EditorGUILayout.Space(2);
            {
                EditorGUILayout.PropertyField(angularVelocity, new GUIContent("AngularVelocity"));
                EditorGUILayout.PropertyField(startWithAngular, new GUIContent("Start With Angular Velocity"));
                if (GUILayout.Button("Apply Angular Velocity"))
                {
                    rv.ApplyAngularVelocity();
                }
            }

            serializedObject.ApplyModifiedProperties();
        }
    }
}
