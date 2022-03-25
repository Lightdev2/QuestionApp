<template>
  <button class="button">
    <slot name="label"></slot>
  </button>
</template>

<script>
export default {
  name: "FlatButton",
};
</script>

<style scoped lang="scss">
.button {
  font-size: 12px;
  border-radius: 3px;
  outline: none;
  background-color: transparent;
  padding: 0.6rem;
  color: var(--blue600);
  border: none;
  cursor: pointer;
  &:hover {
    background-color: var(--blue50);
  }
}
</style>
