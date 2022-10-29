import React from 'react';
import {SafeAreaView, StatusBar, StyleSheet, View} from 'react-native';
import {Feather} from 'react-native-vector-icons';

export default function App() {
  return (
    <SafeAreaView style={styles.container}>
      <StatusBar style="auto"></StatusBar>
      <View style={styles.telaA} />
      <View style={styles.telaB} />
      <View style={styles.telaC} />
    </SafeAreaView>
  );
}

const styles = StyleSheet.create({
  container: {
    flex: 1,
    flexDirection: 'row',
    justifyContent: 'space-between',
  },
  telaA: {
    backgroundColor: '#F5555F',
    height: 100,
    width: 150,
  },
  telaB: {
    backgroundColor: '#55F',
    height: 100,
    flex: 1,
  },
  telaC: {
    backgroundColor: '#F5F',
    height: 100,
    flex: 2,
  },
});
