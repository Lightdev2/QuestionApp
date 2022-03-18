<template>
  <h1 class="title">
    <slot></slot>
  </h1>
</template>

<script>
export default {
  name: "QTitlte",
}
</script>

<style scoped>
.title {
  color: var(--black900);
  font-size: 2.07692308rem !important;
  margin: 0;
}
</style>