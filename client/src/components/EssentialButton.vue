<template>
<button class="button">
  <slot name="label"></slot>
</button>
</template>

<script>
export default {
  name: "PrimaryButton"
}
</script>

<style scoped lang="scss">
.button {
  font-size: 12px;
  border-radius: 3px;
  outline: none;
  background-color: var(--blue500);
  padding: 0.6rem;
  color: var(--black900);
  border: none;
  cursor: pointer;
  &:hover {
    background-color: var(--blue600);
  }
}
</style>
