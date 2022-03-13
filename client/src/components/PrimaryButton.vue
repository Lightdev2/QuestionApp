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
  background-color: var(--powder100);
  padding: 0.6rem;
  color: var(--powder700);
  border: 1px solid var(--powder500);
  cursor: pointer;
  &:hover {
    background-color: var(--powder400);
  }
}
</style>
